# Write your MySQL query statement below
select class from 
(select class, count(*) as count from courses group by class) as cc
where cc.count >= 5;