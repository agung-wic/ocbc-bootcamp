create database db_userdata;

use tb_userdata;

create table tb_userinfo(
    id int primary key auto increment,
	names varchar(200) not null,
	username varchar(100) not null,
	password varchar(255) not null
);