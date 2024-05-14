# Write your MySQL query statement below
select round( sum(case when a.event_date is not null then 1 else 0 end) / count(*), 2 ) as fraction from Activity a right join

(select * from Activity where (player_id, event_date) in
(select player_id, min(event_date) from Activity group by player_id)) as b

on DATE_ADD(b.event_date , interval 1 day) = a.event_date and a.player_id = b.player_id