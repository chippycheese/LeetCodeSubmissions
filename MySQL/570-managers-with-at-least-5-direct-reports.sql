# Write your MySQL query statement below\
select name from
(select e.id, e.name, count(*) as reports_to from employee e left join employee m on e.id = m.managerId where m.managerId is not null group by m.managerId) as em
where reports_to >= 5