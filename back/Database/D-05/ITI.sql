/*
*
*
*/

-- 1. Retrieve number of students who have a value in their age.
select COUNT(*) from Student
where St_Age is not null;

-- 2. Get all instructors Names without repetition
select DISTINCT Ins_Name from Instructor

-- 3. Display student with the following Format (use isNull function) Student ID Student Full Name Department name
select isNull(s.St_Fname+' '+s.St_Lname,' ') as [Full Name],isNull(d.Dept_Name,' ') as [Department name]
from Student as s
inner join Department as d
on d.Dept_Id = s.Dept_Id

-- 4. Display instructor Name and Department Name Note:
--display all the instructors if they are attached to a department or not
select * from Instructor i
left join Department d
on d.Dept_Id = i.Dept_Id

-- 5. Display student full name and the name of the course he is taking For only courses which have a grade  
select s.St_Fname+' '+s.St_Lname as [Full Name],c.Crs_Name,sc.Grade
from Student as s
inner join Stud_Course sc
on sc.St_Id = s.St_Id
inner join Course c
on c.Crs_Id = sc.Crs_Id
where sc.Grade is not null;

-- 6. Display number of courses for each topic name
select t.Top_Name, COUNT(*) [Num Courses]
from Course c
inner join Topic t 
on t.Top_Id = c.Top_Id
group by t.Top_Name;

-- 7. Display max and min salary for instructors
select MAX(i.Salary) [Max Salary],MIN(i.Salary)[Min Salary]
from Instructor i

-- 8. Display instructors who have salaries less than the average salary of all instructors.
select i.Ins_Name , i.Salary
from Instructor i
where i.Salary< (select AVG(Salary) from Instructor)

-- 9. Display the Department name that contains the instructor who receives the minimum salary.
select d.Dept_Name, i.Ins_Name
from Department d
inner join Instructor i 
on i.Dept_Id = d.Dept_Id
where i.Salary = (select MIN(Salary) from Instructor)

-- 10. Select max two salaries in instructor table. 
select top 2 Salary
from Instructor
order by  Salary DESC;

/* 11. Select instructor name and his salary but 
	if there is no salary display instructor bonus keyword. “use coalesce Function” */
select i.Ins_Name ,COALESCE( i.Salary , 0)
from Instructor i

 -- 12.	Select Average Salary for instructors 
 select AVG(i.Salary) Avrage
 from Instructor i

 -- 13. Select Student first name and the data of his supervisor 
 select s.St_Fname , super.*
 from Student s
 inner join Student super
 on super.St_super = s.St_Id

/*14.	Write a query to select the highest two salaries
	in Each Department for instructors who have salaries. “using one of Ranking Functions”*/
SELECT d.Dept_Name, s.Salary
FROM (
  SELECT i.Dept_Id, i.Salary, DENSE_RANK() OVER (PARTITION BY i.Dept_Id ORDER BY i.Salary DESC) AS Rank
  FROM Instructor i
  WHERE i.Salary IS NOT NULL
) s
INNER JOIN Department d
ON d.Dept_Id = s.Dept_Id
WHERE s.Rank <= 2;

-- 15. Write a query to select a random  student from each department.  “using one of Ranking Functions”
SELECT d.Dept_Name, fs.St_Fname, fs.St_Lname
FROM (
  SELECT Dept_Id, s.St_Fname, s.St_Lname, ROW_NUMBER() OVER (PARTITION BY Dept_Id ORDER BY NEWID()) AS RowNum
  FROM Student s
) fs
INNER JOIN Department d ON d.Dept_Id = fs.Dept_Id
WHERE fs.RowNum = 1;