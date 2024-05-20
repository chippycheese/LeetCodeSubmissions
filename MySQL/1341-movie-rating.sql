# Write your MySQL query statement below
(select u.name as results from
(select user_id, count(*) as ratings from MovieRating group by user_id) as c
left join users u on u.user_id = c.user_id order by ratings desc, u.name limit 1)
union all
(select title as results from 
(select movie_id, avg(rating) as rating from MovieRating where created_at like "2020-02-%" group by movie_id) as mr
left join Movies m on m.movie_id = mr.movie_id order by rating desc, title limit 1)