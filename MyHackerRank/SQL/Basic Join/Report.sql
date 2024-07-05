select s.name as Name, g.grade, s.marks from Students s
join Grades g on s.marks >= g.min_mark and s.marks <= g.max_mark
where g.grade > 7
union all
select null as Name, g1.grade, s1.marks from Students s1
join Grades g1 on s1.marks >= g1.min_mark and s1.marks <= g1.max_mark
where g1.grade <= 7
order by grade desc, Name, marks;
