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

-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------

------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id = 30

select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id = 60


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id in(30,60,90)

--IT_PROG ,SA_MAN

select  last_name ,salary , job_id , hire_date , department_id
from employees
where job_id  = 'IT_PROG'

select  last_name ,salary , job_id , hire_date , department_id
from employees
where job_id  = 'SA_MAN'

select  last_name ,salary , job_id , hire_date , department_id
from employees
where  job_id   in('IT_PROG','SA_MAN')


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id is null


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id is not null





select  last_name ,salary , job_id , hire_date , department_id 
from employees
where  department_id not in(30,60,90)

select  last_name,salary,hire_date ,department_id
from  employees
where hire_date not between '2000-01-01'   and '2000-12-31'  
order by   hire_date asc 

select  last_name ,salary , job_id , hire_date , department_id
from employees
where last_name like'%z'

select  last_name ,salary , job_id , hire_date , department_id
from employees
where last_name like'R%'

select  last_name ,salary , job_id , hire_date , department_id
from employees
where last_name like'%ee%'

* Display the employee name, job, and department for all employees is not
  work at department 30 or  department 50 or departments 70

  select  first_name + ' ' +last_name as employee_name ,job_id ,department_id
from employees
where  department_id not in(30,50,70)


* Display the employee name, department, and salary for all employees 
who have no commission (NULL)



select  * 
from employees

  select  first_name + ' ' +last_name as employee_name ,job_id ,salary ,commission_pct
from employees
where commission_pct is null


* Display the last name, job, and salary for all employees 
whose salary is not equal 
to $2,500, $3,500, or $7,000.



select  last_name ,job_id , salary 
from employees
where salary not in(2500,3500,7000)


select  last_name,salary,hire_date ,department_id
from  employees
where salary >=6000



select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50    and   salary >=6000 



select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50    or   salary >=6000 


--IT_PROG ,SA_REP




select  last_name ,job_id , salary 
from employees
where  job_id = 'IT_PROG'  or  job_id = 'SA_REP' 





select  last_name ,job_id , salary 
from employees
where  job_id   in ('IT_PROG' ,'SA_REP' )    and  salary > 9000

* Write a query that displays the last name and salary for all employees whose name starts 
with the letters “J,” “A,” or “M.” and the salary more than 6000 SR 
after that  Sort the results descending by the employees’ last names.

select  last_name  , salary 
from employees
where  (last_name like'J%'   or   last_name like'A%'  or  last_name like'M%')    and   salary>6000






 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------