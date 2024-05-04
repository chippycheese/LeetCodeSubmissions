# Write your MySQL query statement below
select product_id, ifnull( round( sum(sum) / sum(units), 2), 0) as average_price
from
(select p.product_id, price * units as sum, u.units from prices p left join unitssold u on
 p.product_id = u.product_id and 
 p.start_date <= u.purchase_date and
 p.end_date >= u.purchase_date)
 as sold
 group by product_id