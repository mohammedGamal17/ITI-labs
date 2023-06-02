/*
9.	Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB
10.	Display Department name with its manager name using cursor. Use ITI DB
11.	Try to display all instructor names in one cell separated by comma. Using Cursor . Use ITI DB
12.	Try to generate script from DB ITI that describes all tables and views in this DB
*/


/*
-- 1. Create a view that displays student full name, course name if the student has a grade more than 50. 
*/

create view passed_courses as
select CONCAT(s.St_Fname, ' ', s.St_Lname) as student_name, c.Crs_Name as course_name
from student s
join Stud_Course sc 
on sc.St_Id = s.St_Id
join Course c
on c.Crs_Id = sc.Crs_Id
where sc.grade > 50;

select * from passed_courses;

/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

/*
-- 2. Create an Encrypted view that displays manager names and the topics they teach.
*/
create view vmangerName
with encryption
as
select d.Dept_Manager as mangerName , d.Dept_Desc as deptDesc
from Department d

select * from vmangerName;
/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

/*
3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 
*/

create view vInstName
as 
select i.Ins_Name as instructorName , d.Dept_Name
from Instructor i
inner join Department d
on d.Dept_Id = i.Dept_Id
where d.Dept_Name='SD' or d.Dept_Name='Java'

select * from vInstName

/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

/*
4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
		Note: Prevent the users to run the following query 
		Update V1 set st_address=’tanta’
		Where st_address=’alex’;
*/

alter view V1 as
select s.St_Id as id, s.St_Fname as fName, s.St_Lname as lName, s.St_Address as adrress
from student s
where s.St_Address in ('alex', 'Cairo')
with check option;

update v1 set adrress = 'tanta'
where adrress='alex'

select * from v1

/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

/*
5.	Create a view that will display the project name and the number of employees work on it.
“Use Company DB”
*/
use Company_SD;

create view vCompany as
select p.Dnum as projectName, COUNT(e.SSN) as employeeCount
from Project p
inner join Departments d on d.Dnum = p.Dnum
inner join Employee e on e.Dno = p.Dnum
group by p.Dnum;

select * from vCompany

/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

/*
6.	Create the following schema and transfer the following tables to it 
	a.	Company Schema 
		i.	Department table (Programmatically)
		ii.	Project table (by wizard)
	b.	Human Resource Schema
	i.	  Employee table (Programmatically)
*/

-- Create the Company schema
CREATE SCHEMA Company;

-- Create the Department table in the Company schema
CREATE TABLE Company.Department (
  Dnum INT PRIMARY KEY,
  Dname VARCHAR(50),
  Dlocation VARCHAR(50)
);

-- Transfer the Department table to the Company schema
ALTER SCHEMA Company TRANSFER dbo.Department;

-- Create the Project table using a wizard or manually, then transfer it to the Company schema using the following command:
ALTER SCHEMA Company TRANSFER dbo.Project;

-- Create the Human Resource schema
CREATE SCHEMA "Human Resource";

-- Create the Employee table in the Human Resource schema
CREATE TABLE "Human Resource".Employee (
  SSN INT PRIMARY KEY,
  Ename VARCHAR(50),
  Salary DECIMAL(10,2),
  Dno INT
);

-- Transfer the Employee table to the Human Resource schema
ALTER SCHEMA "Human Resource" TRANSFER Employee;

/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

/* 
7. Create index on column (manager_Hiredate) that allow u to cluster the data in table Department.
What will happen?  - Use ITI DB
*/
use ITI;
create clustered index I1
on dbo.Instructor (ins_name)

/*
Error Msg: Cannot create more than one clustered index on table 'dbo.Instructor'.
			Drop the existing clustered index 'PK_Instructor' before creating another.
*/


/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

-- 8. Create index that allow u to enter unique ages in student table. What will happen?  - Use ITI DB
use ITI;
create unique index I2
on Student(st_age)

/*
Error Msg: The CREATE UNIQUE INDEX statement terminated because a duplicate key was found for the object name
			'dbo.Student' and the index name 'I2'. The duplicate key value is (21).
*/

/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

/*
9.Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 
	and increases it by 20% if Salary >=3000. Use company DB
*/
Use Company_SD;
declare c1 cursor for
select e.Salary from Employee e
declare @salary float
open c1
fetch c1 into @salary
while @@FETCH_STATUS = 0
	begin
		if @salary < 3000
			update Employee set Salary = @salary * 1.1
			where current of c1
		else
			update Employee set Salary = @salary * 1.2
			where current of c1
		fetch c1 into @salary
	end
close c1
deallocate c1;


/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

-- 10. Display Department name with its manager name using cursor. Use ITI DB
use ITI;
declare c1 cursor for
select i.Ins_Name, d.Dept_Name
from Instructor i
inner join Department d
on d.Dept_Id = i.Dept_Id

declare @department varchar(20)
declare @manger varchar(20)
declare @table Table(Manger varchar(50),Department varchar(50)) 
open c1 
fetch c1 into @manger,@department

while @@FETCH_STATUS=0
	begin
	insert into @table values (@manger,@department)
	fetch c1 into @manger,@department
	end
close c1
deallocate c1

select * from @table

/*****************************************************************/
/*****************************************************************/
/*****************************************************************/

-- 11. Try to display all instructor names in one cell separated by comma. Using Cursor . Use ITI DB
Use ITI;

declare c1 cursor for
select i.Ins_Name
from Instructor i
declare @name varchar(20)
declare @all_names varchar(300)
open c1 
fetch c1 into @name
while @@FETCH_STATUS=0
	begin
	set @all_names= concat(@name, ', ',@all_names)

	fetch c1 into @name
	end
close c1
deallocate c1

select @all_names

/*12.	Try to generate script from DB ITI that describes all tables and views in this DB*/
select name as [Tables]
from sys.tables
select  name as [Views]
from sys.views