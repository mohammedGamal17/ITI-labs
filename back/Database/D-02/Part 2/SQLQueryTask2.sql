-- 1. desplay all employee date
select * from Employee;

-- 2. Display the employee First name, last name, Salary and Department number
select Fname , Lname ,Salary , Dno
from Employee;

-- 3. Display all the projects names, locations and the department which is responsible about it.
select Pname , Plocation ,Dnum 
from Project;

/*
 4. If you know that the company policy is to pay an annual commission
 for each employee with specific percent equals 10% of his/her annual salary .
 Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
*/
select Fname + ' ' + Lname  as [Full name] , Salary * 0.1 as [annual commission]
from Employee;

-- 5. Display the employees Id, name who earns more than 1000 LE monthly.
select SSN ,Fname + ' ' + Lname  as [Full name] 
from Employee
Where Salary > 1000 

-- 6. Display the employees Id, name who earns more than 10000 LE annually.
select SSN ,Fname + ' ' + Lname  as [Full name] 
from Employee
Where (Salary * 12) > 10000 

-- 7. Display the names and salaries of the female employees 
select Fname + ' ' + Lname  as [Full name] , Salary
from Employee
Where Sex = 'f'

-- 8. Display each department id, name which managed by a manager with id equals 968574.
select Dnum
from Departments
Where MGRSSN = 968574

-- 9. Dispaly the ids, names and locations of  the pojects which controled with department 10.
select Pnumber , Pname ,Plocation
from Project
Where Dnum = 10