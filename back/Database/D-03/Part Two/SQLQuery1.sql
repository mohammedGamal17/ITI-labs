/*
•	All Ids are Identity
•	All Foreign keys are not identity
•	All foreign keys have cascade rule on delete and update
•	Age and Netsalary are calculated attributes but it will be on instructor table creation
•	Netsalary=salary+overtime
•	Age=current year – birthdate year
•	Address has only cairo or alex value
•	All salaries in the range from 1000 to 5000
•	Salary has a default value = 3000
•	Overtime is unique
•	Capacity of each lab under 20 seats
•	Lab is weak entity
•	Hiredate has a default value= current system data
•	Duration of each course is unique
*/
 use DayThree;
create table Instructor(
	Instructor_ID INT IDENTITY(1,1), -- PK
	Fname nvarchar(50),
	Lname nvarchar(50),
	Address nvarchar(50), -- only cairo and alex 
	Hiredate date default getdate(),
	BD date,
	Age as(year(getdate())-year(BD)),
	Salary INT default 3000, -- Range 1000 to 5000
	Overtime INT,
	NetSalary as(isnull(Salary,0) + isnull(Overtime,0)),

	constraint c1 PRIMARY KEY (Instructor_ID),
	constraint c2 check (Address in('cairo','alex')),
	constraint c3 check (Salary between 1000 and 5000),
	constraint c4 unique(Overtime),
)

create table Course(
	Course_ID INT IDENTITY(1,1), -- PK
	CName nvarchar(50),
	Duration INT, -- unique

	constraint c5 PRIMARY KEY (Course_ID),
	constraint c6 unique(Duration),
)

create table Instructor_Courses(
	Instructor_ID INT , -- PK and FK1
	Course_ID INT , -- PK and FK2
	
	constraint c7 PRIMARY KEY (Instructor_ID , Course_ID),
	constraint c8 FOREIGN KEY (Instructor_ID) REFERENCES Instructor(Instructor_ID),
	constraint c9 FOREIGN KEY (Course_ID) REFERENCES Course(Course_ID),
)

create table Lab(
	Course_ID INT , -- PK and FK
	Lab_ID INT IDENTITY(1,1), -- PK
	Location nvarchar(50),
	Capacity INT, -- MAX 20

	constraint c10 PRIMARY KEY (Lab_ID , Course_ID),
	constraint c11 FOREIGN KEY (Course_ID) REFERENCES Course(Course_ID),
	constraint c12 check(Capacity between 0 and 20),
)