create database kantor;

use kantor;

create table employee(
	id int primary key auto_increment,
    nama varchar(50) not null,
    jenis_kelamin enum("Laki-laki", "Perempuan"),
    alamat varchar(100)
);

insert into employee(nama, jenis_kelamin, alamat)
values('John Doe', 'Laki-laki', 'Pagedangan'),
("Alicia Jordan", "Perempuan", "Surabaya"),
("Smith", "Laki-laki", "Manado"),
("James Dron","Laki-laki","Jakarta");