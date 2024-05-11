# Write your MySQL query statement below
select contest_id, round( (registered / total * 100), 2) as percentage from
(Select  contest_id, count(contest_id) as registered, total_count as total from register cross join
(select count(user_id) as total_count from users) as e group by contest_id) as f
order by percentage desc, contest_id