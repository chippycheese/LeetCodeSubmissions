# Write your MySQL query statement below
Select e.name, b.bonus from Employee e left join bonus b on e.empid = b.empid where b.bonus is NULL OR b.bonus < 1000; 