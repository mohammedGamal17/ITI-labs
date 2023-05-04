

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
select  e.Fname +' '+e.Lname as [full name ] , d.Dependent_name
from Employee e
 join Dependent d
on e.SSN = d.ESSN
where d.Dependent_name = null

SELECT e.Fname +' '+e.Lname as [Full Name] 
FROM employee as e
WHERE NOT EXISTS (
    SELECT *
    FROM employee as mang
    INNER JOIN dependent
	ON mang.SSN = dependent.ESSN
    WHERE mang.SSN = e.SSN
)

-- 6.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
-- 7.	Retrieve a list of employee’s names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
-- 8.	Try to get the max 2 salaries using sub query
-- 9.	Get the full name of employees that is similar to any dependent name
-- 10.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.

-- 11.	In the department table insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'

-- 12.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 
--		a.	First try to update her record in the department table
--		b.	Update your record to be department 20 manager.
--		c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)

-- 13.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--	Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

-- 14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
