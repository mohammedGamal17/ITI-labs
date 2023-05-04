-- 1.	Display the Department id, name and id and the name of its manager.
select d.Dnum as DID, d.Dname , e.SSN as [Manager ID] , e.Fname + ' ' +e.Lname as [Manager Name]
from Departments d, Employee e
where e.Superssn = d.MGRSSN


-- 2.	Display the name of the departments and the name of the projects under its control.
/*
select d.Dname , p.Pname
from Project p , Departments d 
where p.Dnum = d.Dnum
*/

select d.Dname , p.Pname
from Project p
inner join Departments d
on p.Dnum = d.Dnum


-- 3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select d.* , e.Fname
from Dependent d
right join Employee e
on d.ESSN = e.SSN


-- 4.	Display the Id, name and location of the projects in Cairo or Alex city.
select p.Pnumber ,p.Pname,p.Plocation 
from Project p
where p.City='Cairo' or p.City='Alex'


-- 5.	Display the Projects full data of the projects with a name starts with "a" letter.
select *
from Project 
where Pname like'ad'


-- 6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * from Employee e
where e.Dno = 30 and e.Salary>1000 and e.Salary<2000 


-- 7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select e.Fname + ' ' + e.Lname as [ Full Name]
from Employee e
join Departments d
on e.Dno = d.Dnum
join Project p
on p.Dnum = d.Dnum
where d.Dnum=10 and p.Pname = 'AL Rabwah'


-- 8.	Find the names of the employees who directly supervised with Kamel Mohamed.
-- i try sub quary but not work --
select e.Fname + ' ' + e.Lname as [ Full Name]
from Employee e
inner join Employee mang
on e.Superssn = mang.SSN
where mang.Fname ='Kamel'and mang.Lname ='Mohamed'


-- 9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select e.Fname + ' ' + e.Lname as [ Full Name] , p.Pname
from Employee e
join Departments d
on e.Dno = d.Dnum
join Project p
on p.Dnum = d.Dnum
ORDER BY p.Pname ; -- defult Sort ASC, if need change ORDER BY p.Pname DESC; 


-- 10.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select p.Pnumber , d.Dname , e.Lname , e.Address ,e.Bdate
from Employee e
join Departments d
on e.SSN = d.MGRSSN
join Project p
on p.Dnum = d.Dnum
where p.City = 'Cairo'


-- 11.	Display All Data of the managers
select mang.*
from Employee e
inner join Employee mang
on e.Superssn = mang.SSN


-- 12.	Display All Employees data and the data of their dependents even if they have no dependents
select e.* ,d.*
from Employee e
left join Dependent d
on e.SSN = d.ESSN


-- 13.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
INSERT INTO employee (ssn, fname,lname, Bdate, address, sex, salary, superssn, dno)
VALUES ('77777', 'Mohammed', 'Gamal', '1999-04-01', 'Alexandria, Egypt', 'M', 7000, '223344', 30);


-- 14.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
INSERT INTO employee (ssn, fname,lname, Bdate, address, sex, dno)
VALUES ('66666', 'Ahmed', 'Gamal', '2000-04-01', 'Alexandria, Egypt', 'M', 30);

-- 15.	Upgrade your salary by 20 % of its last value.
UPDATE employee SET salary = salary * 1.2  WHERE ssn = 77777;

