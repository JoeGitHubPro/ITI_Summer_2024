
--corss join
select St_Fname, Dept_name
from student, Department

select St_Fname, Dept_name
from Student cross join Department

-- inner join
select St_Fname, Dept_name
from student S, Department D
where D.Dept_Id = S.Dept_Id

select St_Fname, Dept_name
from student S inner join Department D
on D.Dept_Id = S.Dept_Id

select St_Fname, Dept_name
from student S, Department D
where D.Dept_Id = S.Dept_Id and St_Address = 'Alex'

select St_Fname, Dept_name
from student S inner join Department D
on D.Dept_Id = S.Dept_Id
where St_Address = 'Alex'

select St_Fname, Dept_name
from student S inner join Department D
on D.Dept_Id = S.Dept_Id and St_Address = 'Alex'

-- outer join
--1 left outer join

select St_Fname, Dept_name
from student S left outer join Department D
on D.Dept_Id = S.Dept_Id


--2 right outer join

select St_Fname, Dept_name
from student S right outer join Department D
on D.Dept_Id = S.Dept_Id

--3 full outer join

select St_Fname, Dept_name
from student S full outer join Department D
on D.Dept_Id = S.Dept_Id

-- self join

select S.ST_Fname as StudentName, Sup.St_Fname as SuperName
from student as S inner join student Sup
on Sup.St_Id = S.St_super
order by Sup.St_Fname

------------------------

update Stud_Course set Grade += 10

update Stud_Course set Grade += 10 
from Student inner join Stud_Course
on Student.St_Id = Stud_Course.St_Id
where St_Address = 'Alex'


----------------------------------

select St_Fname, Crs_Name, Grade
from Student S, Course C, Stud_Course SC
where S.St_Id = SC.St_Id and 
C.Crs_Id = SC.Crs_Id and S.St_Address ='Cairo'


select St_Fname, Crs_Name, Grade
from Student S inner join Stud_Course SC
on S.St_Id = SC.St_Id
inner join Course C
on C.Crs_Id = SC.Crs_Id

------------------------------------------------
