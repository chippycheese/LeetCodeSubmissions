# Write your MySQL query statement below
select machine_id, round( avg(processing_time) , 3 ) as processing_time 
from
(select a1.machine_id, a2.timestamp - a1.timestamp as processing_time  from Activity as a1 inner join Activity a2 on a1.machine_id = a2.machine_id and a1.process_id = a2.process_id and a1.activity_type = 'start' and a2.activity_type = 'end' and a1.timestamp < a2.timestamp) as processingTable
group by machine_id