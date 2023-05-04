use DayThree;

select * from Instructor;
select * from  Course;

select * from Instructor_Courses;
select * from Lab;


INSERT INTO Instructor_Courses (Instructor_ID, Course_ID)
VALUES (1, 4);

select i.fName , ic.Course_ID , c.CName
from Instructor i
join Instructor_Courses ic
on i.Instructor_ID = ic.Instructor_ID
join Course c 
on c.Course_ID = ic.Course_ID