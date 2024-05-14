# Write your MySQL query statement below
select e.employee_id, e.department_id from Employee e left join 
(select employee_id, count(*) as departments from employee group by employee_id) as ec
on ec.employee_id = e.employee_id where 
(ec.departments > 1 and e.primary_flag = 'Y') or (ec.departments = 1)