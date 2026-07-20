 ***********************Session 4**********************************
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


-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------
select  * 
from employees

select  * 
from jobs

select  * 
from departments


select first_name ,department_name
from employees  join  departments
on employees.department_id = departments.department_id

select e.first_name ,d.department_name
from employees e  join  departments d
on e.department_id = d.department_id


select  e.first_name ,j.job_title
from employees e join jobs j
on e.job_id = j.job_id


select  * 
from countries

* Write a query for the HR department to produce the addresses of all the 
departments. Use the LOCATIONS tables. Show the  street address, 
city, state or province, and country  in the output. 

select  * 
from departments


select  * 
from LOCATIONS

select  department_name , street_address,city,state_province,country_name
from departments d join  LOCATIONS l
on d.location_id = l.location_id
join countries c
on l.country_id = c.country_id



select  d.department_name , l.street_address,l.city,l.state_province,l.country_id,l.location_id
from departments d join  LOCATIONS l
on d.location_id = l.location_id


select  * 
from employees

select  * 
from jobs

select  * 
from departments




select e.first_name ,d.department_name,job_title
from employees e  join  departments d
on e.department_id = d.department_id
join jobs j
on e.job_id = j.job_id

* The HR department needs a report of employees in Toronto. Display the last name, 
job, department number, and the department name for all employees who work in 
Toronto. 


select  * 
from jobs

select  * 
from departments


select  * 
from locations


select  last_name  ,job_title ,e.department_id ,department_name
from employees e join jobs j   
on e.job_id = j.job_id
join departments  d
on e.department_id = d.department_id
join  locations l 
on d.location_id =l.location_id
where city = 'Toronto'






select e.first_name ,d.department_name
from employees e  inner join  departments d
on e.department_id = d.department_id
where salary >15000



select e.first_name ,d.department_name
from employees e  cross join  departments d
where  e.department_id = d.department_id and salary >15000

select e.first_name ,d.department_name,job_title
from employees e  join  departments d
on e.department_id = d.department_id
join jobs j
on e.job_id = j.job_id



select e.first_name ,d.department_name,job_title
from employees e cross  join  departments d cross join jobs j
where  e.department_id = d.department_id and e.job_id = j.job_id

select e.first_name ,d.department_name,job_title
from employees e ,  departments d , jobs j
where  e.department_id = d.department_id and e.job_id = j.job_id and salary >15000


select  last_name  ,job_title ,e.department_id ,department_name
from employees e join jobs j   
on e.job_id = j.job_id
join departments  d
on e.department_id = d.department_id
join  locations l 
on d.location_id =l.location_id
where city = 'Toronto'

select  last_name ,job_title ,city
from employees e , jobs j ,departments d ,locations l 
where e.job_id = j.job_id and e.department_id = d.department_id and d.location_id = l.location_id and city = 'Toronto'



------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------








 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------