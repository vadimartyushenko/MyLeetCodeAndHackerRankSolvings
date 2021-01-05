-- Create table
create table TRIANGLES
(
  a     integer not null,
  b   integer not null,
  c  integer not null
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
  
insert into TRIANGLES s
(s.a, s.b, s.c)
values
--(20, 20, 23);
--(20, 20, 20);
--(20, 21, 22);  
(13, 14, 30);
--решение
select
case
  when a+b<c or a+c<b or c+b<a then 'Not A Triangle'
  else case 
         when a=b and b=c and a=c then 'Equilateral'
         when a=b or b=c or a=c then 'Isosceles'
         else 'Scalene'
       end   
end
from triangles;
  
