

-- 1.	Display (Using Union Function)
--		a.	 The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--		b.	 And the male dependence that depends on Male Employee.
select d.Dependent_name , d.Sex
from Dependent d
inner join employee e
on d.ESSN = e.SSN
where e.Sex = 'F' and d.Sex = 'F'
union
select d.Dependent_name, d.Sex
from Dependent d 
inner join employee e
on d.ESSN = e.SSN
where e.Sex = 'M' and d.Sex = 'M'

-- 2.	For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.Pname ,sum(w.Hours) as [sum]
from project p
inner join Works_for w
on p.Pnumber = w.Pno
group by p.Pname



-- 3.	Display the data of the department which has the smallest employee ID over all employees' ID.
select d.*
from Departments d
inner join employee e
on d.Dnum = e.Dno
where e.SSN = (select min(SSN) from employee)


-- 4.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.Dname  , max(e.Salary) as max ,  min(e.Salary) as [min] , avg(e.Salary) as [avrage]
from Departments d
inner join Employee e
on d.Dnum = e.Dno
group by d.Dname


-- 5.	List the full name of all managers who have no dependents.
select mang.Fname +' '+mang.Lname as [Full Name] 
from employee as mang
where not exists (
    select * , d.Dependent_name
    from employee as e
    inner join dependent d
	on e.SSN = d.ESSN
    where e.SSN = mang.SSN
)

-- 6.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
select d.Dnum, d.Dname , count(e.SSN) as [Num Employees]
from Departments d
inner join Employee e
on d.Dnum = e.Dno
group by  d.Dnum, d.Dname
having avg(e.salary) < (select avg(salary) from employee)


-- 7.	Retrieve a list of employee’s names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
select e.Fname +''+ e.Lname as [Name], p.Pname
from  Departments d
inner join Employee e
on d.Dnum = e.Dno
inner join Works_for w
on e.SSN = w.ESSn
inner join project p
on w.Pno = p.Pnumber
order by  d.Dnum, e.Lname, e.Fname

-- 8.	Try to get the max 2 salaries using sub query
select e.SSN, e.Salary
from Employee e
where salary in (
  select distinct top 2 salary
  from employee
  order by  salary desc
)

-- 9.	Get the full name of employees that is similar to any dependent name
select distinct e.Fname +''+ e.Lname as [Name]
from employee e
inner join dependent d
on e.SSN = d.ESSN
where exists ( 
    select *
    from employee as em2
    inner join dependent d2
	on em2.SSN = d2.ESSN
    where em2.SSN = e.SSN
	and em2.Fname like concat('%', d2.Dependent_name, '%')
	or em2.Lname like concat('%', d2.Dependent_name, '%')
)

-- 10.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
select e.SSN, concat(e.Fname , ' ', e.Lname) as EmployeeName
from employee e
where exists (
    select *
    from dependent
    where dependent.ESSN = e.SSN
)


-- 11.	In the department table insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
INSERT INTO Departments(Dnum, Dname, MGRSSN, [MGRStart Date])
VALUES (100, 'DEPT IT', 112233, '2006-11-01')


-- 12.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 
--		a.	First try to update her record in the department table
--		b.	Update your record to be department 20 manager.
--		c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)

			--a.
			/* Move MR:Noha */
			update Departments
			set MGRSSN = 968574
			where Dnum = 100
			/* Move Me */
			update Departments
			set MGRSSN = 968574
			where Dnum = 20

-- 13.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--	Hint: (
--			a. Check if Mr. Kamel has dependents,
--			b. works as a department manager,
--			c. supervises any employees
--			d. or works in any projects and handle these cases
--			).
select count(*)
from Dependent
where ESSN = (
  select SSN 
  from employee
  where SSN = 223344
)

-- 14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
update Employee
set salary = salary * 1.3
where SSN in (
  select SSN
  from Works_for w
  where w.Pno = (
    select p.Pnumber
    from project p
    where p.Pname = 'Al Rabwah'
  )
)

/*
use this just for quere to select employee 

select e.Salary , e.Lname , p.Pname
from Employee e
join Works_for w
on w.ESSn = e.SSN
join Project p
on p.Pnumber = w.Pno
where p.Pname = 'Al Rabwah'
*
