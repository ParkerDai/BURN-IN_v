#!/bin/sh
if [ -d "/mnt/jffs2" ]
then
chmod 777 /mnt/jffs2/*
/mnt/jffs2/tcp_server422&

elif [ -d "/flash" ]
then
chmod 777 /flash/*
/flash/tcp_server422&

elif [ -d "/jffs2" ]
then
chmod 777 /jffs2/*
/jffs2/tcp_server422&
fi

