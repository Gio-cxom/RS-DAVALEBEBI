--TASK1
--select first_name, last_name, job_id, salary  from Table_2 where first_name LIKE'S%'

--TASK2
--select * from Table_2 where salary=(select Max(salary) from Table_2);

--TASK3   ??????????????????
--SELECT MAX(SALARY) FROM Table_2 WHERE SALARY < (SELECT MAX(SALARY) FROM Table_2);

--TASK4
--select *from Table_2

--select min(salary) from Table_2 where
--salary in (select top(3) salary from Table_2
--order by salary desc)

--TASK5
--select * from Table_2

--select first_name,salary, manager_id from Table_2 where manager_id>0

--TASK6
--SELECT w.manager_id,
--       count(*)
--FROM Table_2 w,
--     Table_2 m
--WHERE w.manager_id = m.employee_id
--GROUP BY w.manager_id
--ORDER BY w.manager_id ASC;

--TASK7
--select * from Table_2
--select department_id, COUNT(*)
--from Table_2
--Group by department_id

--TASK8
--?????????????????????????
--TASK9
--select * from Table_2
--SELECT department_id,AVG(SALARY) AS 
--AVERAGE_SALARY FROM Table_2 GROUP BY department_id;

--SELECT AVG(SALARY) AS 
--AVERAGE_SALARY FROM Table_2;

--TASK10
--????????????????

--TASK11
--select first_name, last_name, job_id, salary  from Table_2 where first_name LIKE'an%'

--TASK12
--SELECT
--[phone_number]
--,FORMAT([phone_number],'###-###-####') AS [Formatted Phone]
--FROM Table_2

--TASK13
--??????????????????

--TASK14
--SELECT last_name, salary 
--FROM Table_2 
--where salary>(select avg(salary) from Table_2)

--TASK15

--SELECT department_id, MAX(SALARY) FROM Table_2 GROUP BY department_id;

--TASK16

--SELECT *
--FROM Table_2 e
--WHERE 5>
--    (SELECT count(*)
--     FROM Table_2
--     WHERE e.salary >salary);

--TASK17 TASK19?

--SELECT *
--FROM Table_2
--WHERE hire_date<('1990-1-1') ;
--SELECT *
--FROM Table_2
--WHERE hire_date>('2000-1-15') ;

--TASK18 ??????????

--SELECT REVERSE (first_Name) AS reverce FROM Table_2;
--select REVERSE (last_Name) AS reverce FROM Table_2

--TASK20


