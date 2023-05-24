create database ITICSharp

create table Department(
Id int primary key identity,
Name varchar(50),
Capacity int default 35,

constraint c1 check(Capacity between 30 and 35)
)

create table Student(
Id int primary key identity,
Name varchar(50),
age int,
departmentId int,

constraint c2 foreign key(departmentId) references Department(Id)
)

insert into student(name,age,DepartmentId) values('test',25,1)