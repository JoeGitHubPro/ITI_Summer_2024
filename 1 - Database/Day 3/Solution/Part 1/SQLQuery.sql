--1.	Display the name of the departments and the name of the projects under its control.

SELECT 
    d.Dname AS Department_Name, 
    p.Pname AS Project_Name
FROM 
    Departments d
JOIN 
    Project p ON d.Dnum = p.Dnum;



--2.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.

SELECT 
    dep.*, 
    e.Fname + ' ' + e.Lname AS Employee_Name
FROM 
    Dependent dep
JOIN 
    Employee e ON dep.ESSN = e.SSN;




--3.	Display the Id, name and location of the projects in Cairo or Alex city.

SELECT 
    Pnumber AS Project_ID, 
    Pname AS Project_Name, 
    Plocation AS Project_Location
FROM 
    Project
WHERE 
    City IN ('Cairo', 'Alex');


--4.	Display the Projects full data of the projects with a name starts with "a" letter.

SELECT 
    *
FROM 
    Project
WHERE 
    Pname LIKE 'a%';


--5.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
SELECT 
    *
FROM 
    Employee
WHERE 
    Dno = 30 AND 
    Salary BETWEEN 1000 AND 2000;

--6.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
SELECT 
    e.Fname, 
    e.Lname
FROM 
    Employee e
JOIN 
    Works_for wf ON e.SSN = wf.ESSn
JOIN 
    Project p ON wf.Pno = p.Pnumber
WHERE 
    e.Dno = 10 AND 
    wf.Hours >= 10 AND 
    p.Pname = 'AL Rabwah';



--7.	Find the names of the employees who directly supervised with Kamel Mohamed.

SELECT 
    e.Fname, 
    e.Lname
FROM 
    Employee e
JOIN 
    Employee s ON e.Superssn = s.SSN
WHERE 
    s.Fname = 'Kamel' AND 
    s.Lname = 'Mohamed';

--8.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.

SELECT 
    e.Fname, 
    e.Lname, 
    p.Pname
FROM 
    Employee e
JOIN 
    Works_for wf ON e.SSN = wf.ESSn
JOIN 
    Project p ON wf.Pno = p.Pnumber
ORDER BY 
    p.Pname;


--9.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.

SELECT 
    p.Pnumber, 
    d.Dname AS Department_Name, 
    m.Lname AS Manager_LastName, 
    m.Address AS Manager_Address, 
    m.Bdate AS Manager_Birthdate
FROM 
    Project p
JOIN 
    Departments d ON p.Dnum = d.Dnum
JOIN 
    Employee m ON d.MGRSSN = m.SSN
WHERE 
    p.City = 'Cairo';

--10.	Display All Data of the mangers

SELECT 
    *
FROM 
    Employee
WHERE 
    SSN IN (SELECT MGRSSN FROM Departments);


--11.	Display All Employees data and the data of their dependents even if they have no dependents

SELECT 
    e.*, 
    d.Dependent_name, 
    d.Sex AS Dependent_Sex, 
    d.Bdate AS Dependent_Birthdate
FROM 
    Employee e
LEFT JOIN 
    Dependent d ON e.SSN = d.ESSN;



	--Data Manipulating Language:

--1.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
INSERT INTO Employee (Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno)
VALUES ('Youssef', 'Mohamed', 102672, '2001-12-11', 'suez', 'M', 3000, 112233, 30);

--2.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or manager number to him.
INSERT INTO Employee (Fname, Lname, SSN, Bdate, Address, Sex, Dno)
VALUES ('Ayman', 'Mohamed', 102660, '2003-6-9', 'Ismalia', 'M', 30);

--3.	Upgrade your salary by 20 % of its last value.
UPDATE Employee
SET Salary = Salary * 1.20
WHERE SSN = 102672;

