# Write your MySQL query statement below
select (Select DISTINCT salary from Employee order by salary desc limit 1 offset 1 ) as SecondHighestSalary from Employee limit 1