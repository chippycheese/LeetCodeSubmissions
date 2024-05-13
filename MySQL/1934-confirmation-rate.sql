# Write your MySQL query statement below
select user_id, 
    round( 
        sum(case when action = 'confirmed' then amount else 0 end)
        / 
        sum(amount)
        , 2  ) as confirmation_rate
from(
select s.user_id, c.action, count(*) as amount from Confirmations c right join signups s on c.user_id = s.user_id group by s.user_id, c.action
) as g group by user_id 