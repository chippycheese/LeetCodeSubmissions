# Write your MySQL query statement below
select s.student_id, s.student_name, c.subject_name, count(e.student_id) as attended_exams 
from students as s
cross join Subjects as c
LEFT JOIN examinations e on s.student_id = e.student_id and e.subject_name = c.subject_name
group by s.student_id, s.student_name, c.subject_name 
order by s.student_id, c.subject_name