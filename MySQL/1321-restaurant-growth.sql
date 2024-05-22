# Write your MySQL query statement below
select visited_on,  
    (select sum(amount) from customer where 
    visited_on <= c.visited_on and visited_on >= date_sub(c.visited_on, interval 6 day) 
    ) as amount,
    (select round(sum(amount) / 7, 2 ) from customer where 
    visited_on <= c.visited_on and visited_on >= date_sub(c.visited_on, interval 6 day) 
    ) as average_amount
from customer c where visited_on >=
(select date_add(min(visited_on), interval 6 day) from Customer) group by visited_on