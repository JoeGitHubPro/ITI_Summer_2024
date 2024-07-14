select * from Instructor

select count(*) from Instructor

select count(*), count(st_id), count(st_Lname), count(st_age)
from Student

select * from Student


select avg(st_age) from Student

select sum(st_age)/count(*) from student

---isnull(column, value) => check if value is null then replace it with the other value

select sum(st_age)/count(isnull(st_age, 0)) from Student

select sum(salary) as sum, Dept_Id from Instructor
group by Dept_Id


select max(salary), dept_id from Instructor
where Ins_Degree is not null
group by Dept_Id


select max(salary), dept_id from Instructor
group by Dept_Id
having count(*) >= 5

select sum(st_age), st_address, dept_id from student
group by St_Address, Dept_Id

select max(salary), i.dept_Id, dept_name from Instructor I
join Department D
on d.Dept_Id = i.Dept_Id
group by i.Dept_Id, dept_name



------------------------

--SubQueries

select * from Instructor
where Dept_Id in (select dept_id from department where Dept_Name= 'SD')

select I.* from Instructor I inner join Department D
on D.Dept_Id = i.Dept_Id
where Dept_Name = 'SD'

select st_age from Student
where st_age > Avg(st_age) --xxxxxxxxxxxxxxxxx

select st_age from student
where st_age > (select avg(st_Age) from student)

select distinct(st_Fname) from student
where St_Fname is not null

select count(st_fname) from Student

---------------------------------------------

-- union family
-- union all, --union, --except --intersect


select st_fname as name from Student
union all
select Ins_name from Instructor

select st_fname+ ' ' + st_lname from Student
union all
select ins_name from instructor


select st_fname as name from Student
union
select Ins_name from Instructor

select st_fname as name from Student
intersect
select Ins_name from Instructor


select st_fname as name from Student
except
select Ins_name from Instructor

--------------------------------------
--subquery + DML

delete from Stud_Course
where st_id = 1

delete from Stud_Course
where St_Id in (select St_Id from student where St_Address = 'alex')


------------------------------------------------

--top , top with ties
select top(2) * from student

select top(3) * from student 
where St_Address = 'Alex'

select top(2) st_age from student
order by st_age

select top(2) st_age from student
order by st_age desc

select top(5) with ties * from Student
order by st_age

-------------------------------------------
select newId() --GUID 

select * from student
order by newId()

select top(3) * from student
order by newId()
--------------------------------------------

select st_fname + ' ' + st_lname as fullname from Student
order by fullname

select st_fname + ' ' + st_lname as fullname from Student
where fullname = 'ahmed adel'

--from
--join
--on
--where
--group by
--having
--select
--order by
--top

select st_fname + ' ' + st_lname as fullname from Student
where st_fname + ' ' + st_lname = 'ahmed adel'

select fullname from 
(
select st_fname + ' ' + st_lname as fullname from Student
) as newTable
where fullname = 'ahmed adel'

--------------------------------------------------

--full path for DB objects

--[Server Name].[DB Name].[schema name].[object name]

select * from Student

select * from [Company_SD].[dbo].project

select st_fname from student
union
select Fname from [Company_SD].[Dbo].Employee

----------------------------------------------------
--DDL
--select into

select * into table2
from Student


select st_fname, st_lname into ST_copy
from student

select * from ST_copy

select * into table3
from Student
where St_Address = 'Cairo'

select * into table4
from Student
where 1 = 2


select * from Student where 1 = 2

select * into table6
from Student
where St_age < -1000

----------------------------------------------

-- insert based on select

insert into table6
select * from Student

select * from table6
------------------------------------------------
select * from
(select *, ROW_NUMBER() over(order by salary desc) as RN
	,Dense_Rank() over(order by salary desc) as DR
	, Ntile(3) over(order by salary desc) as Groups
from Instructor
) as newTable

where DR = 3


select * from (
select *, /*ROW_NUMBER() over(partition by dept_id order by salary desc) as RN*/
	Dense_Rank() over(partition by dept_id order by salary desc) as DR
from Instructor
) as newtable

where DR = 1



