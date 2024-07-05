-- Create table
create table OCCUPATIONS
(
  name varchar2(20) not null,
  occupation varchar2(20) not null
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    minextents 1
    maxextents unlimited
  );
  
insert into OCCUPATIONS s
(s.name, s.occupation)
values
--('Samantha', 'Doctor');  
--('Julia', 'Actor');
--('Maria', 'Actor');
--('Meera', 'Singer');
  ('Ashely', 'Professor');
--решение
select name ||'('|| substr(occupation,1,1)||')' from OCCUPATIONS
order by name;
select 'There are a total of ' || count (occupation) ||' ' || lower(occupation)||'s.' from OCCUPATIONS
group by occupation
order by count (occupation), lower(occupation);
