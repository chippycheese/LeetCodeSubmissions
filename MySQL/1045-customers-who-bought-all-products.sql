# Write your MySQL query statement below
select customer_id from
(select distinct customer_id, product_key from Customer)as c group by customer_id
having count(c.customer_id) =
(select count(*) as count from product)