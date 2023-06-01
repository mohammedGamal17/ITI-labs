/*
*/
use ITI;

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

-- 1. Create a scalar function that takes date and returns Month name of that date.
create function getMonthName(@date DATE)
returns varchar(20)
as
begin
 declare @month varchar(20)
 set @month = DATENAME(MONTH,@date)
 return @month
end

select dbo.getMonthName('2023-5-30') as Month

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

-- 2. Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
create function getSubtract(@fNum int , @sNum int)
returns @subtractTable Table(outNum int)
as
begin
declare @num int = @fNum;
while @num<=@sNum
	begin
		insert into @subtractTable(outNum) values (@num)
		set @num = @num + 2
	end
	return
end

select * from dbo.getSubtract(1,10);

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

-- 3. Create inline function that takes Student No and returns Department Name with Student full name.
create function getDepName(@studentNo int)
returns table
as
return(
select d.Dept_Name , CONCAT(s.St_Fname,' ',s.St_Lname) [Full Name]
from Department d
inner join Student s
on s.Dept_Id = d.Dept_Id
where s.St_Id = @studentNo
)

select * from dbo.getDepName(5)

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

/*
4. Create a scalar function that takes Student ID and returns a message to user 
	a.	If first name and Last name are null then display 'First name & last name are null'
	b.	If First name is null then display 'first name is null'
	c.	If Last name is null then display 'last name is null'
	d.	Else display 'First name & last name are not null'
*/

create function getFullName (@studentID int)
returns varchar(50)
as
begin
	declare @fName varchar(20)
	declare @lName varchar(20)

    select @fName= s.St_Fname ,  @lName= s.St_Lname
    from Student s
    where s.St_Id = @studentID;
    if @fName is null and @lName is null
        return 'First name & last name are null';
    else if @fName is null
        return 'First name is null';
    else if @lName is null
        return 'Last name is null';
    return 'First name & last name are not null';
END

select dbo.getFullName(5) [Full Name]

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

/*
5. Create inline function that takes integer which represents manager ID and displays department name,
	Manager Name and hiring date
*/

create function getManager(@managerID int)
returns Table
as
return
(
select d.Dept_Name,d.Dept_Manager,d.Manager_hiredate
from Department d
inner join Instructor i
on d.Dept_Id = i.Dept_Id
where i.Ins_Id = @managerID
)

select * from getManager(12)

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

/*
6.	Create multi-statements table-valued function that takes a string
		If string='first name' returns student first name
		If string='last name' returns student last name 
		If string='full name' returns Full Name from student table 
		Note: Use “ISNULL” function
*/

create function getName(@string varchar(20))
returns @table Table(nName varchar(20))
as
begin
	if @string = 'first name'
		insert into @table(nName)
		select s.St_Fname
		from Student s
	else if @string = 'last name'
		insert into @table(nName)
		select s.St_Lname
		from Student s
	else if @string = 'full name'
		insert into @table(nName)
		select CONCAT(s.St_Fname,' ', s.St_Lname)
		from Student s
	else
		insert into @table(nName)
		select 'Invalid input'

	return
end

select * from getName('first name')
select * from getName('last name')
select * from getName('full name')

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

-- 7. Write a query that returns the Student No and Student first name without the last char

select s.St_Id , LEFT(s.St_Fname, LEN(s.St_Fname)-1)
from Student s

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

-- 8. Wirte query to delete all grades for the students Located in SD Department
delete from Stud_Course
where St_Id in (
  select St_Id
  from Student s
  inner join Department d on d.Dept_Id = s.Dept_Id
  where d.Dept_Name = 'SD'
);

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

-- 9. Using Merge statement between the following two tables [User ID, Transaction Amount]
MERGE INTO Table1 t1
USING Table2 t2
ON (t1.[User ID] = t2.[User ID])
WHEN MATCHED THEN
  UPDATE SET t1.[Transaction Amount] = t1.[Transaction Amount] + t2.[Transaction Amount]
WHEN NOT MATCHED THEN
  INSERT ([User ID], [Transaction Amount]) VALUES (t2.[User ID], t2.[Transaction Amount]);

/**************************************************************************/
/**************************************************************************/
/**************************************************************************/

/*
10. Try to Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB
then allow him to select and insert data into tables and deny Delete and update
*/
USE ITI;
GRANT SELECT, INSERT ON dbo.Student TO ITIStud;
GRANT SELECT, INSERT ON dbo.Course TO ITIStud;
DENY DELETE, UPDATE ON dbo.Student TO ITIStud;
DENY DELETE, UPDATE ON dbo.Course TO ITIStud;