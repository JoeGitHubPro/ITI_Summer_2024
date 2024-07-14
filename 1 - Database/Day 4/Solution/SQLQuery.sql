--1.	Display (Using Union Function)
--a.	 The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--b.	 And the male dependence that depends on Male Employee.
SELECT d.Dependent_name, d.Sex
FROM Dependent d
JOIN Employee e ON d.ESSN = e.SSN
WHERE d.Sex = 'Female' AND e.Sex = 'Female'
UNION
SELECT d.Dependent_name, d.Sex
FROM Dependent d
JOIN Employee e ON d.ESSN = e.SSN
WHERE d.Sex = 'Male' AND e.Sex = 'Male';



--2.	For each project, list the project name and the total hours per week (for all employees) spent on that project.
SELECT 
    p.Pname, 
    SUM(wf.Hours) AS Total_Hours_Per_Week
FROM 
    Project p
JOIN 
    Works_for wf ON p.Pnumber = wf.Pno
GROUP BY 
    p.Pname;

--3.	Display the data of the department which has the smallest employee ID over all employees' ID.

SELECT 
    d.*
FROM 
    Departments d
JOIN 
    Employee e ON d.Dnum = e.Dno
WHERE 
    e.SSN = (SELECT MIN(SSN) FROM Employee);

--4.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
SELECT 
    d.Dname, 
    MAX(e.Salary) AS Max_Salary, 
    MIN(e.Salary) AS Min_Salary, 
    AVG(e.Salary) AS Avg_Salary
FROM 
    Departments d
JOIN 
    Employee e ON d.Dnum = e.Dno
GROUP BY 
    d.Dname;

--5.	List the last name of all managers who have no dependents.
SELECT 
    e.Lname
FROM 
    Employee e
WHERE 
    e.SSN IN (SELECT MGRSSN FROM Departments)
    AND NOT EXISTS (SELECT 1 FROM Dependent d WHERE d.ESSN = e.SSN);

--6.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
SELECT 
    d.Dnum, 
    d.Dname, 
    COUNT(e.SSN) AS Num_Employees
FROM 
    Departments d
JOIN 
    Employee e ON d.Dnum = e.Dno
GROUP BY 
    d.Dnum, d.Dname
HAVING 
    AVG(e.Salary) < (SELECT AVG(Salary) FROM Employee);

--7.	Retrieve a list of employees and the projects they are working on ordered by department and within each department, ordered alphabetically by last name, first name.
SELECT 
    d.Dname AS Department, 
    e.Lname, 
    e.Fname, 
    p.Pname
FROM 
    Employee e
JOIN 
    Departments d ON e.Dno = d.Dnum
JOIN 
    Works_for wf ON e.SSN = wf.ESSn
JOIN 
    Project p ON wf.Pno = p.Pnumber
ORDER BY 
    d.Dname, 
    e.Lname, 
    e.Fname;

--8.	Try to get the max 2 salaries
SELECT TOP 2 
    Salary
FROM 
    Employee
ORDER BY 
    Salary DESC;

--9.	Get the full name of employees that is similar to any dependent name
SELECT 
    e.Fname + ' ' + e.Lname AS Full_Name
FROM 
    Employee e
JOIN 
    Dependent d ON e.Fname + ' ' + e.Lname = d.Dependent_name;

--10.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 
UPDATE 
    Employee
SET 
    Salary = Salary * 1.30
WHERE 
    SSN IN (SELECT ESSn FROM Works_for wf JOIN Project p ON wf.Pno = p.Pnumber WHERE p.Pname = 'AL Rabwah');

