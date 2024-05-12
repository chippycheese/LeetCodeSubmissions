# Write your MySQL query statement below
select sell_date, count(sell_date) as num_sold, GROUP_CONCAT(product order by product SEPARATOR ',') AS products from 
(select distinct sell_date, product from  Activities)
 as a
 group by sell_date order by sell_date