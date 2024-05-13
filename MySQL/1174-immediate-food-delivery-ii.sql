# Write your MySQL query statement below
select  round(avg(case when customer_pref_delivery_date = order_date then 1 else 0 end) * 100, 2) as immediate_percentage  from 
    (
        SELECT * FROM Delivery where (customer_id, order_date) in
        (SELECT customer_id, MIN(order_date) FROM Delivery GROUP BY customer_id)
    ) as e

