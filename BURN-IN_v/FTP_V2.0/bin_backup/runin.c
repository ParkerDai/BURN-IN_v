#include <stdio.h>
#include <sys/types.h>            //socket();
#include <sys/socket.h>
#include <netinet/in.h>
#include <netinet/tcp.h>
#include <sys/file.h>
#include <sys/stat.h>
#include <sys/ioctl.h>
#include <fcntl.h>
#include <net/if.h>                //struct ifreq
#include <net/route.h>            //struct rtentry
#include <unistd.h>
#include <fcntl.h>
#include <string.h>
#include <sys/time.h>
#include <termios.h>
#include <errno.h>
#include "runin.h"

#define port 55950

int sockfd;
int fd;
FILE *file;
struct sockaddr_in addr;
struct sockaddr_in des_addr;
int namelen;
unsigned char mac[12];

int loopback() {
    int fd1,fd2;
    struct termios tio1,tio2;
    int mode = 2;	// original is 1; changed by alex 2006.07.13
    int i, res, cnt;
    char c;
    struct timeval tp;
    unsigned long time1=0;
    unsigned long time2=0;

    fd1 = open("/dev/ttyS1", O_RDWR | O_NOCTTY | O_NONBLOCK);
    fd2 = open("/dev/ttyS2", O_RDWR | O_NOCTTY | O_NONBLOCK);

    ioctl(fd1, 0x9000, &mode);
    ioctl(fd2, 0x9000, &mode);
    tcgetattr(fd1, &tio1);
    tcgetattr(fd2, &tio2);
 
    tio1.c_cflag = B115200 | CS8 | CLOCAL | CREAD;
    tio2.c_cflag = B115200 | CS8 | CLOCAL | CREAD;
    tio1.c_iflag = 0;
    tio2.c_iflag = 0;
    tio1.c_lflag = 0;
    tio2.c_lflag = 0;
    tio1.c_oflag = 0;
    tio2.c_oflag = 0;

    tcsetattr(fd1, TCSANOW, &tio1);
    tcsetattr(fd2, TCSANOW, &tio2);

    usleep(10000);
    while(read(fd2, &c, 1) > 0);

    for (i = 0; i < 256; i++ )
    {
        gettimeofday(&tp, NULL);
        time1 = tp.tv_sec*1000000+tp.tv_usec;
        while ((cnt = write(fd1, &i, 1)) < 0)
            if (errno == EAGAIN)
                continue;
            else
                break;
                                                                                
        while ((cnt = read(fd2, &c, 1)) < 0)
            if (errno == EAGAIN) {
                gettimeofday(&tp, NULL);
                time2 = tp.tv_sec*1000000+tp.tv_usec;
                                                                                
                // if no response in 2 seconds, then timeout
                if((time2 - time1) >= 2000000) {
                    // printf("rs232 loopback test failed\n");
                    return -1;
                }
                continue;
            }
            else
                break;
                                                                                
        if (c != (char) i) {
            // printf("char mismatch : %d - %d\n", i, c);
            close(fd1);
            close(fd2);
            return -1;
        }
                                                                                
    }
    close(fd1);
    close(fd2);
    // printf("rs232 loopback test ok\n");
    return 1;

}

void get_mac() {
    unsigned char mtmp[6];
    struct ifreq ifr;
// printf("get mac\n");
    memset(&ifr, 0, sizeof(ifr));
    sprintf(ifr.ifr_name, "eth0");
    ifr.ifr_addr.sa_family = AF_INET;
    if (ioctl(sockfd, SIOCGIFHWADDR, &ifr) == 0) {
        bcopy(ifr.ifr_hwaddr.sa_data, mtmp, 6);
    }
    sprintf(mac, "%02X%02X%02X%02X%02X%02X", mtmp[0], mtmp[1], mtmp[2],
            mtmp[3], mtmp[4], mtmp[5]);
    // printf("%s\n", mac);
}

int main() {
    int i;
    int res;
    socklen_t fromlen;
    unsigned int des_ip;
    unsigned char command[128];

    // i = 1;


    sockfd = socket(AF_INET, SOCK_DGRAM, 0);

    if ( sockfd < 0)
        printf("socket error");

    addr.sin_family = AF_INET;
    addr.sin_addr.s_addr = htonl(INADDR_ANY);
    addr.sin_port = htons(port);

    if (bind(sockfd, (struct sockaddr *)&addr, sizeof(addr)) < 0)
        printf("bind error");

    get_mac();

    // if ((fd = open("./test.runin", O_RDWR)) < 0) {
    if ((fd = open("/flash/test.runin", O_RDWR)) < 0) {
        close(fd);
atop1:
        memset(command, 0, sizeof(command));
        bzero(&des_addr, sizeof(des_addr));

        res = recvfrom(sockfd, command, sizeof(command), 0,
              (struct sockaddr *)&des_addr, &fromlen);
        if (res > 0) {
            // Receive command1 from server and enter Run-in mode
            if (command[0] == 0x02 && command[1] == 0x01 &&
                command[18] == 0x01 && command[20] == 0x03) {
                // fd = open("./test.runin", O_RDWR | O_CREAT,
                fd = open("/flash/test.runin", O_RDWR | O_CREAT,
                     S_IRUSR | S_IWUSR);
                if (fd > 0) {
                    des_ip =
                    ntohl(((struct sockaddr_in *)&des_addr)->sin_addr.s_addr);
                    // printf("ip=%08x\n", des_ip);
                    write(fd, &des_ip, sizeof(des_ip));
                    close(fd);

                    memset(command, 0, sizeof(command));
                    // To tell server that BOX enters Run-in mode
                    // send command2 to server                    
                    command[0] = 0x02; // Header
                    command[1] = 0x02; // BodyType
                    command[2] = 0x3d; // Length
                    memcpy(command+3, mac, 12);
                    command[31] = 0x01;
                    command[65] = 0x03; //Trailer
                    sendto(sockfd, command, 66, 0,
                          (struct sockaddr *)&des_addr,
                          sizeof(struct sockaddr_in));

                    // To tell server that BOX Flash ready
                    memset(command, 0, sizeof(command));
                    command[0] = 0x02; // Header
                    command[1] = 0x05; // BodyType
                    command[2] = 0x1c; // Length
                    memcpy(command+3, mac, 12);
                    command[15] = 0x30;
                    command[16] = 0x31;
                    command[17] = 0x30;
                    command[18] = 0x31; // Flash ready
                    command[19] = 0x30;
                    command[20] = 0x30;
                    memset(command+21, 0x30, 12);
                    command[32] = 0x03; //Trailer
                    sendto(sockfd, command, 33, 0,
                          (struct sockaddr *)&des_addr,
                          sizeof(struct sockaddr_in));

                    system("reset");
                }
                else {
                    // To tell server that BOX Flash failed
                    memset(command, 0, sizeof(command));
                    command[0] = 0x02; // Header
                    command[1] = 0x05; // BodyType
                    command[2] = 0x1c; // Length
                    memcpy(command+3, mac, 12);
                    command[15] = 0x30;
                    command[16] = 0x31;
                    command[17] = 0x30;
                    command[18] = 0x32; // Flash Failed
                    command[19] = 0x30;
                    command[20] = 0x30;
                    memset(command+21, 0x30, 12);
                    command[32] = 0x03; //Trailer
                    sendto(sockfd, command, 33, 0,
                          (struct sockaddr *)&des_addr,
                          sizeof(struct sockaddr_in));
                    while(1)
                        usleep(10000000);
                }
            }
            else {
                if (command[0] == 0x02 && command[1] == 0x03 &&
                    command[18] == 0x00 && command[20] == 0x03) {
                    memset(command, 0, sizeof(command));
                    // To tell server that BOX enters normal mode
                    // send command2 to server                    
                    command[0] = 0x02; // Header
                    command[1] = 0x04; // BodyType
                    command[2] = 0x3d; // Length
                    memcpy(command+3, mac, 12);
                    command[31] = 0x00;
                    command[65] = 0x03; //Trailer
                    sendto(sockfd, command, 66, 0,
                          (struct sockaddr *)&des_addr,
                          sizeof(struct sockaddr_in));

                }
                goto atop1;
            }
        }
    }
    else {
        memset(&des_ip, 0, sizeof(des_ip));
        read(fd, &des_ip, sizeof(des_ip));
        close(fd);

        for (i = 0; i < 10; i++) {
            if(loopback() > 0) {
                memset(command, 0, sizeof(command));
                res = recvfrom(sockfd, command, sizeof(command), MSG_DONTWAIT,
                      (struct sockaddr *)&des_addr, &fromlen);
                if (res > 0) {
                    // Receive command3 from server and enter normal mode
                    if (command[0] == 0x02 && command[1] == 0x03 &&
                        command[18] == 0x00 && command[20] == 0x03) {
                        memset(command, 0, sizeof(command));
                        // To tell server that BOX enters normal mode
                        // send command4 to server                    
                        command[0] = 0x02; // Header
                        command[1] = 0x04; // BodyType
                        command[2] = 0x3d; // Length
                        memcpy(command+3, mac, 12);
                        command[31] = 0x00;
                        command[65] = 0x03; //Trailer
                        sendto(sockfd, command, 66, 0,
                              (struct sockaddr *)&des_addr,
                              sizeof(struct sockaddr_in));
                        goto stop1;
                    }
                    // Receive command1 from server and enter Run-in mode
                    if (command[0] == 0x02 && command[1] == 0x01 &&
                        command[18] == 0x01 && command[20] == 0x03) {
                        memset(command, 0, sizeof(command));
                        // To tell server that BOX enters Run-in mode
                        // send command4 to server                    
                        command[0] = 0x02; // Header
                        command[1] = 0x02; // BodyType
                        command[2] = 0x3d; // Length
                        memcpy(command+3, mac, 12);
                        command[31] = 0x01;
                        command[65] = 0x03; //Trailer
                        sendto(sockfd, command, 66, 0,
                              (struct sockaddr *)&des_addr,
                              sizeof(struct sockaddr_in));
                    }
                }
                usleep(1000);
            }
            else {
                goto stop;
            }


        }
        // To tell server that BOX Serial port ready
        memset(command, 0, sizeof(command));
        command[0] = 0x02; // Header
        command[1] = 0x05; // BodyType
        command[2] = 0x1c; // Length
        memcpy(command+3, mac, 12);
        command[15] = 0x31;
        command[16] = 0x31;
        command[17] = 0x30;
        command[18] = 0x31;
        command[19] = 0x30;
        command[20] = 0x30;
        memset(command+21, 0x30, 12);
        command[32] = 0x03; //Trailer
        des_addr.sin_family = AF_INET;
        des_addr.sin_addr.s_addr = htonl(des_ip);
        des_addr.sin_port = htons(port);
        sendto(sockfd, command, 33, 0,
              (struct sockaddr *)&des_addr,
              sizeof(struct sockaddr_in));
        // unlink("/flash/test.runin");
        system("reset");
stop:
        // To tell server that BOX Serial port failed
        memset(command, 0, sizeof(command));
        command[0] = 0x02; // Header
        command[1] = 0x05; // BodyType
        command[2] = 0x1c; // Length
        memcpy(command+3, mac, 12);
        command[15] = 0x32;
        command[16] = 0x31;
        command[17] = 0x30;
        command[18] = 0x31;
        command[19] = 0x30;
        command[20] = 0x30;
        memset(command+21, 0x30, 12);
        command[32] = 0x03; //Trailer
        des_addr.sin_family = AF_INET;
        des_addr.sin_addr.s_addr = htonl(des_ip);
        des_addr.sin_port = htons(port);
        sendto(sockfd, command, 33, 0,
              (struct sockaddr *)&des_addr,
              sizeof(struct sockaddr_in));
        goto stop2;
stop1:
        unlink("/flash/test.runin");
stop2:
        system("reset");
    }

    return 0;
}
