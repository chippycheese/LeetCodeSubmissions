# Write your MySQL query statement below
select w2.id as Id from weather as w1 left join weather w2 on w1.recordDate = DATE_SUB(w2.recordDate, interval 1 day) where w1.temperature < w2.temperature;