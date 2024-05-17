-- # Write your MySQL query statement below
select distinct p.product_id, ifnull(pp.new_price, 10) as price from products p left join

(select product_id, new_price from Products p 
where (product_id, change_date) in
(select product_id, max(change_date) from products where change_date <= '2019-08-16' group by product_id)) as pp

on p.product_id = pp.product_id

order by p.product_id