create database db_movies;

use db_movies;

create table tb_movie(
	id int PRIMARY KEY AUTO_INCREMENT,
    name varchar(100) not null,
    genre varchar(50) not null,
    duration varchar(10) not null,
    release_date date not null
);

insert into tb_movie(name, genre, duration, release_date)
values("Bad Boys for Life", "Action/Comedy", "2h 5 mins", "2020-01-23"),
("John Wick", "Action/Thriller", "1h 41 mins", "2014-10-24"),
("The Martian", "Si-fi/Drama", "2h 31 mins", "2015-10-02"),
("How to Train Your Dragon: The Hidden World", "Animation/Family", "1h 45 mins", "2020-01-23");