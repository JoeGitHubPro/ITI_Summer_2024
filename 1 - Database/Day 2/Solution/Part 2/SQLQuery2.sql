--1.	Display all the employees Data.

select * from Employee



--2.	Display the employee First name, last name, Salary and Department number.

select Fname , Lname ,Salary ,Dno from Employee


--3.	Display all the projects names, locations and the department which is responsible about it.

select Pname , Plocation ,Dnum from Project


--4.	Display the employees Id, name who earns more than 1000 LE monthly.

select SSN , Fname + ' ' + Lname as name from Employee
where Salary > 1000

