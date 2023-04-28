--task 1
--go
--alter function dbo.getEmployeeCount(@department_id as int)
--returns int
--as
--begin
--return(select count(employee_id) from employees where department_id=@department_id)
--end;

--task2
--alter function dbo.locationID(@employee_id as int)
--returns int
--as
--begin
--return(select location_id from departments where department_id=(select department_id from employees where employee_id=@employee_id))
--end;


--task3
--go 
--alter function dbo.getRichest(@department_id as int)
--returns int 
--as begin
--return (select max(salary) from  employees where department_id=@department_id)
--end;

--go
--create function dbo.getRichest2(@department_id as int)
--returns int
--as begin
--return ( select employee_id from employees where salary = (select dbo.getRichest(70))) ???????

--task 4
--go 
--create function dbo.SameDepartments(@employee1 as int, @employee2 as int)
--returns varchar(50)
--as begin
--return case
--when((select department_id from employees where employee_id = @employee1) = (select department_id from employees where employee_id = @employee2))
--then 'true'
--else 'false'
--end
--end;


--task5
--go
--create procedure LocationChange (@department as int, @location as int)
--as
--update departments
--set location_id=@location
--where department_id=@department;
--exec LocationChange 50 ,333;
--select * from departments;

--task 6 
--go 
--create procedure NewRow
--as
--insert into departments(department_id)
--values((select max(department_id) from departments)+10)

--exec NewRow;
--select *from departments;

--task 7
--go 
--create procedure AddEmpployee
--as
--insert into employees(employee_id, department_id)
--values ((select max(employee_id) from employees)+1, (select max(department_id) from departments));
--exec AddEmpployee;
--select *from employees

--task 8
--go 
--create procedure CheckDepartment (@employee1 as int, @employee2 as int)
--as
--begin
--if dbo.SameDepartments(@employee1,@employee2) = 'true' print 'same departments'
--else print 'different departments'
--end;

--exec CheckDepartment 100,101;




