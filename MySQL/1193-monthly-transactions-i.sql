# Write your MySQL query statement below
select CONCAT(YEAR(date),"-", LPAD(MONTH(date),2,0)) as month, country,
sum(trans_count) as trans_count,
sum(approved_count ) as approved_count ,
sum(trans_total_amount ) as trans_total_amount ,
sum(approved_total_amount ) as approved_total_amount 
from(
    Select trans_date as date, country,
 count(amount) as trans_count,
 count(case when state = "approved" then amount else null end) as approved_count,
 sum(amount) as trans_total_amount,
 sum(case when state = "approved" then amount else 0 end) as approved_total_amount
from Transactions group by country, state, trans_date
) as p
group by YEAR(date), MONTH(date), country