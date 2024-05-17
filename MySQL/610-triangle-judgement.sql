# Write your MySQL query statement below
select x,y,z, 
(case 
when ( (x+y) > z AND (x+z) > y AND (y+z) > x ) and (x > 0 and y > 0 and z > 0)   then 'Yes' else 'No' end) as triangle
from Triangle 