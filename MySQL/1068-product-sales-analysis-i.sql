# Write your MySQL query statement below
select product.product_name, sales.year, sales.price from Sales as sales left join Product as product on product.product_id = sales.product_id;