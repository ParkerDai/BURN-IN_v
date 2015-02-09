#!/bin/sh
if [ -d "/mnt/jffs2" ]
then
chmod 777 /mnt/jffs2/*
/mnt/jffs2/tcp_server485&

elif [ -d "/flash" ]
then
chmod 777 /flash/*
/flash/atop_tcp_server485&

elif [ -d "/jffs2" ]
then
chmod 777 /jffs2/*
/jffs2/atop_tcp_server485&
fi

