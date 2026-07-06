 ***********************Session 1**********************************
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
-- SELECT * |  column1, column2, ...
-- FROM table_name
-- [WHERE condition]
-- [ORDER BY column1, column2, ... [ASC|DESC]]



 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >, >=
--   🧮 Range: BETWEEN ... AND ...



-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------

------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------
select *
from employees


select last_name,salary ,hire_date ,job_id,department_id
from employees


select last_name,salary ,hire_date ,job_id,department_id,salary *12 as annual_salary
from employees

select last_name,salary ,hire_date ,job_id,department_id,salary *12 as "annual salary"
from employees

* The HR department wants a query to display the last name, 
job , hire date, and employee ID for each employee, 
with the employee ID appearing first. Provide an alias
STARTDATE for the HIRE_DATE column.

select * 
from employees



select last_name ,job_id,hire_date,employee_id
from employees



select employee_id, last_name ,job_id,hire_date as "STARTDATE"
from employees



select employee_id, last_name ,job_id,hire_date  "STARTDATE"
from employees


select last_name,salary ,hire_date ,job_id,department_id
from employees
where salary >=15000



select last_name,salary ,hire_date ,job_id,department_id
from employees
where  department_id =60



select last_name,salary ,hire_date ,job_id,department_id
from employees
where  job_id = 'SA_REP'


select last_name,salary ,hire_date ,job_id,department_id
from employees
where salary  between  2500	  and 5000


select last_name,salary ,hire_date ,job_id,department_id
from employees
where hire_date  between  '2000-01-01'	  and '2000-12-31'




select salary ,hire_date ,job_id,department_id,last_name
from employees
where salary  between  2500	  and 5000
order by  salary asc


select salary ,hire_date ,job_id,department_id,last_name
from employees
where salary  between  2500	  and 5000
order by  salary desc


select salary ,hire_date ,job_id,department_id,last_name
from employees
where salary  between  2500	  and 5000
order by  last_name 


 Display the employee name and salary for all employees
 who have a salary greater than or equal 4000 and less than or equal  9000 
 and Sorting Data depanden on Salary Who is Have Max Value.




 select first_name  +  ' ' +  last_name  ,salary
from employees 
where salary between   4000 and 9000
order by salary  desc


 select first_name  +  ' bin ' +  last_name as "employee name"  ,salary
from employees 
where salary between   4000 and 9000
order by salary  desc



 select concat(first_name  ,  ' ' ,  last_name) as "employee name"   ,salary
from employees 
where salary between   4000 and 9000
order by salary  desc



 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------