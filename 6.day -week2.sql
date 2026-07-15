 ***********************Session 6**********************************
-- 📘 SQL Server: Full DQL Course - Beginner to Advanced
-- 👨‍🏫 Name: Mohamed Alswaify
-- 📱 Mobile: 0564842804


---------------------------------------------------------
-- 📘 THEORETICAL INTRODUCTION: What is DQL?
------------------------------------------------------------
-- DQL (Data Query Language) is used to fetch data from database objects such as tables and views.
-- The main DQL command is:
--     SELECT

-- 🔹 SQL SELECT SYNTAX:
SELECT *|columns
FROM table name
[WHERE bool-expr AND|OR  bool-expr]
[group by column|expr ]
[having bool-expr]
[order by column|number|expr|alias [ASC][DESC]]



-- 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >, >=
--   🧠 Logical: AND, OR, NOT
--   🧮 Range: not BETWEEN ... AND ...
--   📋 List: [not] IN (...)
--   🔍 Pattern: [not] LIKE 'pattern'
--   🚫 NULL Check: IS NULL, IS NOT NULL


-- * Displaying Data from Multiple Tables Using Joins:

    * FROM table1 [INNER] JOIN table2 ON bool-expr [[INNER] JOIN table3 ON bool-expr ...]
    * FROM table1 CROSS JOIN table2 where bool-expr
    * FROM table1, table2 where bool-expr
    * FROM table1 LEFT|RIGHT|FULL [OUTER] JOIN table2 ON bool-expr [ LEFT|RIGHT|FULL [OUTER] JOIN table3 ON bool-expr ...]


* Reporting Aggregated Data Using the Group Functions:

    max(), min(), sum(), avg(), count()



Introduction to Data Definition Language (DDL) in SQL Server

1. CREATE TABLE:
----------------
Syntax:
    CREATE TABLE table_name (
        column_name datatype [CONSTRAINT constraint_name constraint_type],
        ...,
        [CONSTRAINT constraint_name constraint_type]
    );

Naming Rules:
    - Maximum 128 characters.
    - Can include A-Z, a-z, 0-9, _, @, $, #.
    - Must begin with a letter.
    - Must not be a reserved keyword.

Common Datatypes in SQL Server:
    - Numeric: INT, BIGINT, SMALLINT, DECIMAL(p,s), FLOAT, REAL
    - Text: CHAR(n), VARCHAR(n), TEXT
    - Date/Time: DATE, DATETIME, SMALLDATETIME, TIME
    - Other: BIT, MONEY, UNIQUEIDENTIFIER, VARBINARY(MAX)

Constraint Types:
    - PRIMARY KEY
    - UNIQUE
    - NOT NULL
    - CHECK (condition)
    - FOREIGN KEY REFERENCES other_table(column)


    
Example:
    CREATE TABLE Employees (
        EmployeeID INT PRIMARY KEY,
        FirstName VARCHAR(50) NOT NULL,
        Salary DECIMAL(10, 2) CHECK (Salary > 0),
        DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID)
    );


2. ALTER TABLE:
---------------
Syntax Overview:
    ALTER TABLE table_name
    -- Add a new column
    ADD column_name datatype;

    -- Modify column datatype or nullability
    ALTER COLUMN column_name new_datatype;

    -- Drop a column
    DROP COLUMN column_name;

    -- Add a constraint
    ADD CONSTRAINT constraint_name constraint_type;

    -- Drop a constraint
    DROP CONSTRAINT constraint_name;

Note:
    - RENAME COLUMN is not supported directly; use SQL Server Management Studio (SSMS) or recreate the column.

Example:
    -- Add a column
    ALTER TABLE Employees
    ADD Email VARCHAR(100);

    -- Modify a column
    ALTER TABLE Employees
    ALTER COLUMN Email VARCHAR(150);

    -- Drop a column
    ALTER TABLE Employees
    DROP COLUMN Email;

    -- Add a UNIQUE constraint
    ALTER TABLE Employees
    ADD CONSTRAINT UQ_Email UNIQUE (Email);

    -- Drop a constraint
    ALTER TABLE Employees
    DROP CONSTRAINT UQ_Email;


3. DROP TABLE:
--------------
Syntax:
    DROP TABLE table_name;

Example:
    DROP TABLE Employees;

Note:
    - SQL Server automatically removes constraints with the table.

*/


-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------
------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------






create database  SecondDB;

drop database  SecondDB;

use SecondDB;
----------------------------------------


create table depts
(
Dept_Id  int primary key,
Dept_Name VARCHAR(30) UNIQUE

);


Drop table depts

create table depts
(
Dept_Id  int constraint  depts_Dept_Id_pk primary key,
Dept_Name VARCHAR(30) constraint depts_Dept_Name_UQ  UNIQUE

);



SELECT  * 
FROM depts

INSERT INTO depts
VALUES(2 , 'Applications')




create table My_Emps
(
Emp_Id int constraint  My_Emps_Emp_Id_pk  primary key,
Emp_Name varchar(50) not null ,
salary DECIMAL(8,2) check(salary between   2000  and  8000   ),
Start_Date  date Default GetDate(),
city  varchar(30) default 'Riyadh',
Dept_Id int constraint  My_Emps_Dept_Id_FK   FOREIGN KEY REFERENCES depts(Dept_Id)

);

create table My_Emps
(
Emp_Id int ,
Emp_Name varchar(50) not null ,
salary DECIMAL(8,2),
Start_Date  date Default GetDate(),
city  varchar(30) default 'Riyadh',
Dept_Id int constraint  My_Emps_Dept_Id_FK   FOREIGN KEY REFERENCES depts(Dept_Id),

constraint  My_Emps_Emp_Id_pk  primary key(Emp_Id),
constraint My_Emps_salary_CK  check(salary between   2000  and  8000   )

);

insert into my_emps  (Emp_Id,Emp_Name,salary,Dept_Id)
values(1,'Mohamed Alswaify',2500,1)

select  * 
from my_emps

-- * create courses table as follow:
--   cours_id => pk
--   course_title => not null
--   price => between 800 and 3000
--   start_date => default value the date after 7 days
--   duration => btw 12 and 120

CREATE TABLE Courses
(
Course_Id INT,
Course_Title VARCHAR(100) NOT NULL,
Price DECIMAL(8,2),
Start_Date DATE DEFAULT GETDATE() +7,
Duration INT,
CONSTRAINT Courses_Course_Id_PK PRIMARY KEY (Course_Id),
CONSTRAINT Courses_Price_CK CHECK (Price BETWEEN 800 AND 3000),
CONSTRAINT Courses_Duration_CK CHECK (Duration BETWEEN 12 AND 120)
);

INSERT INTO Courses(Course_Id, Course_Title, Price, Duration)
VALUES
(1,'SQL Server',1500,30),
(2,'ASP.NET Core',2500,60),
(3,'React.js',1800,40);

SELECT *
FROM Courses;

-- * create a projects table 
--   project_id => pk
--   project_name => not null
--   client_name => 
--   hour_rate => positive greater than 1

INSERT INTO Projects
(Project_Id, Project_Name, Client_Name, Hour_Rate)
VALUES
(1,'Training System','Abadnet',120),
(2,'HR Management','ABC Company',95),
(3,'E-Commerce Website','Falcons Law Firm',150);
SELECT *
FROM Projects;

CREATE TABLE Projects
(
Project_Id INT,
Project_Name VARCHAR(100) NOT NULL,
Client_Name VARCHAR(100),
Hour_Rate DECIMAL(8,2),
CONSTRAINT Projects_Project_Id_PK PRIMARY KEY (Project_Id),
 CONSTRAINT Projects_Hour_Rate_CK CHECK (Hour_Rate > 1)
);

-- * create a tasks table
--   task_id => pk
--   description => max char 255
--   start_date => date
--   end_date => greater than start_date
--   project_id => foreign key

create table My_Emps
(
Emp_Id int ,
Emp_Name varchar(50) not null ,
salary DECIMAL(8,2),
Start_Date  date Default GetDate(),
city  varchar(30) default 'Riyadh',
Dept_Id int constraint  My_Emps_Dept_Id_FK   FOREIGN KEY REFERENCES depts(Dept_Id),

constraint  My_Emps_Emp_Id_pk  primary key(Emp_Id),
constraint My_Emps_salary_CK  check(salary between   2000  and  8000   )

);

create table Tasks
(
Task_Id int,
Description varchar(255) not null,
Start_Date date,
End_Date date,
Project_Id int
constraint Tasks_Project_Id_FK  foreign key references Projects(Project_Id),
constraint Tasks_Task_Id_PK primary key (Task_Id),
constraint Tasks_End_Date_CK check (End_Date > Start_Date)
);








 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------