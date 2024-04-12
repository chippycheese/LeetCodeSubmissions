# Write your MySQL query statement below
#select * from customers;

select name as Customers from customers left join orders on Orders.customerId = Customers.id where orders.customerId is NULL;