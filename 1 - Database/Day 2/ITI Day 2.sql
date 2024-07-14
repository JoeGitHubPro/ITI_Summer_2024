Use ITI24

create table department
(
	dnum int primary key,
	dname varchar(50) not null,
	loc varchar(50)
)

alter table Employee add salary int

alter table Employee alter column salary bigint

alter table Employee drop column salary

drop table department


insert into department 
values(1, 'SD', 'Alex')

insert into department
values (2, 'IT', 'cairo'), (3, 'UI', null)

insert into department (dname, dnum)
values ('mobile', 4)


update department set dname = 'web' where dnum = 1

update Employee set name = 'Ali' where SSN > 122


delete from department where dnum = 4

update department set loc = null 


-------------------------------------------


select * from student order by St_age

select * from student where Dept_Id = 10 

select st_fname from student

select * from student order by st_fname, st_Lname

select st_fname + ' ' + st_lname as [full name] from student

select [full name] from student


/*% ===> set of chars, _ ===> one char*/

select * from student where st_fname like 'a%'   

select * from student where st_fname like 'a__'

select * from student where st_fname like '%a%'