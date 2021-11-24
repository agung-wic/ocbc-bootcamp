---A
create database db_staff

---B
use db_staff;

create table tb_staff(
	nik INT,
	nama VARCHAR(50),
	alamat VARCHAR(200),
	handphone VARCHAR(15)
);

---C
insert into tb_staff( nik,nama,alamat,handphone)
values(1001, 'Agung', 'Madiun', '088825718934');

---D
insert into tb_staff( nik,nama,alamat,handphone)
values(1002, 'Iqbal', 'Bondowoso', '088825718934'),
(1003, 'Tono', 'Bandung', '08887825612'),
(1004, 'Hafiz', 'Bandung', '088898769099'),
(1005, 'Mey', 'Bogor', '088825718934');

---E
alter table tb_staff add joindate date;
insert into tb_staff(nik, nama, alamat, handphone, joindate)
values(1006, 'Dane', 'Surabaya', '088867248901', '2021-09-10');

---F
select top 2 * from tb_staff;

---G
SELECT TOP 3 * FROM tb_staff;

---H
create table tb_staff_outsource(
	nik INT,
	nama VARCHAR(50),
	alamat VARCHAR(200),
	handphone VARCHAR(15),
	joindate date
);

---I
insert into tb_staff_outsource(nik, nama, alamat, handphone, joindate)
values(1001, 'Mpu', 'Klaten', '088120051999', '2021-09-10'),
(1002, 'Zakiy', 'Sidoarjo', '088120051999', '2021-09-11'),
(1003, 'Fikar', 'Cilegon', '088120051999', '2021-09-12'),
(1004, 'Fradip', 'Bukittinggi', '088120051999', '2021-09-13'),
(1005, 'Nia', 'Sidoarjo', '088120051999', '2021-09-14'),
(1006, 'Syaidatul', 'Bukittinggi', '088120051999', '2021-09-15'),
(1007, 'Faishal', 'Sidoarjo', '088120051999', '2021-09-16'),
(1008, 'Syiham', 'Surabaya', '088120051999', '2021-09-17'),
(1009, 'Affan', 'Madiun', '088120051999', '2021-09-10'),
(1010, 'Grace', 'Bogor', '088120051999', '2021-09-10');

---J
select * 
from tb_staff a 
join tb_staff_outsource b 
on a.joindate = b.joindate 

---K
select * 
from tb_staff a 
right join tb_staff_outsource b 
on a.joindate = b.joindate

---L
select * 
from tb_staff a 
left join tb_staff_outsource b 
ON a.joindate = b.joindate

---M
select * 
from tb_staff a 
full join tb_staff_outsource b 
on a.joindate = b.joindate

