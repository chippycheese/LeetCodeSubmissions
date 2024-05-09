# Write your MySQL query statement below
select employee_id, name, count(*) as reports_count , round(avg(age),0) as average_age from
(select m.employee_id, m.name, e.age from Employees e right join Employees m on e.reports_to = m.employee_id where e.age is not null) as e
group by employee_id order by employee_id