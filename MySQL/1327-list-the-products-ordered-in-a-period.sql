# Write your MySQL query statement below
select e.product_name, j.unit from 
(select product_id, sum(unit) as unit from orders where order_date like "2020-02-%" group by product_id) as j
left join Products e on e.product_id = j.product_id where j.unit >= 100