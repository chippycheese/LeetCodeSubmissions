# Write your MySQL query statement below
select employee_id from
(select e.employee_id, m.employee_id as manager_id, e.salary from Employees e
left join employees m on m.employee_id = e.manager_id where e.manager_id is not null) as f
where salary < 30000 and manager_id is null order by employee_id;