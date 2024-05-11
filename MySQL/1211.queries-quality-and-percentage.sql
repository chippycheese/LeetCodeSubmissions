# Write your MySQL query statement below
select 
q.query_name,
round(sum((rating / position))/count(q.query_name),2) as quality,
ifnull(round(b_quality/count(q.query_name) * 100,2),0) as poor_query_percentage  

from Queries q left join

(select query_name, count(query_name) as b_quality from Queries where rating < 3
group by query_name) as e on q.query_name = e.query_name
where q.query_name is not null group by query_name