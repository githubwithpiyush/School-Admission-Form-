CREATE DATABASE StudentDB;

USE StudentDB;

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Grade NVARCHAR(10),
    SchoolName NVARCHAR(100)
);

select * from students