 ***********************Session 5**********************************
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





-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------
------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------



SELECT  * 

FROM DEPARTMENTS



SELECT  * 

FROM employees


select department_name ,first_name 
from departments d inner join employees e 
on d.manager_id  =e.employee_id


select department_name ,first_name 
from departments d cross join employees e 
where  d.manager_id  =e.employee_id


select department_name ,first_name 
from departments d left outer join employees e 
on d.manager_id  =e.employee_id


select first_name ,  department_name
from departments d right outer join employees e 
on d.manager_id  =e.employee_id
order by department_name desc

select first_name ,  department_name
from departments d full outer join employees e 
on d.manager_id  =e.employee_id
order by department_name desc
-------------------------------------------------------------------------

select  max(salary),min(salary),sum(salary),avg(salary),count(*)
from employees




select  max(salary),min(salary),sum(salary),avg(salary),count(*)
from employees
where department_id  = 60 


select  e.department_id, department_name , max(salary),min(salary),sum(salary),avg(salary),count(*)
from employees e join departments d
on e.department_id = d.department_id
group by e.department_id, department_name 

Write a query to display the job , maximum salary, minimum salary, total salary, 
average salary , and number of employees for each jobs from the employees table. 
Sort the result by job.



select  j.job_id, j.job_title,   max(salary) maximum,min(salary) minimum,sum(salary) total,avg(salary) average,count(*) num
from employees e join jobs j
on e.job_id = j.job_id
where e.job_id not in('IT_PROG','ST_MAN')   
group by  j.job_id, j.job_title
having count(*) >5



Write a query to display the department_id, department name , maximum salary, minimum salary, total salary, 
average salary (rounded), and number of employees for each department from the employees table. 
Include only departments with department_id greater than 30 and  at least 5 employees. 
Sort the result by department_id.


select  e.department_id, department_name , max(salary),min(salary),sum(salary),avg(salary),count(*)
from employees e join departments d
on e.department_id = d.department_id
where e.department_id >30
group by e.department_id, department_name 
having  count(*)>=5
order by   count(*) desc
-----------------------------------------DML----------------insert ,update ,delete-----------------------------


select  * 
from departments

insert into departments   (department_name,manager_id,location_id)
values                    ('Markting Courses' ,null,null)


insert into departments   (department_id, department_name,manager_id,location_id)
values                    (280,'Markting Courses' ,null,null)

insert into departments 
values                    (280,'Markting Courses' ,null,null)


insert into departments 
values                    (280,'Markting Courses' ,null,null)

insert into departments   (department_id, department_name,manager_id,location_id)
values                    ((select  max(department_id) +10 from departments),'Applications' ,200,2400)




update  departments
set department_name = 'Solutions'
where department_id = 300
 

 delete from  departments

where department_id = 300

 delete  departments

where department_id > 270

select  max(department_id) +10 from departments


select  * 
from locations


select  * 
from employees
------------------------------------


--Insert your date in  employee table
 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------