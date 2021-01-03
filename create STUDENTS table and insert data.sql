-- Create table
create table STUDENTS
(
  id     NUMBER not null,
  name   varchar2(25) not null,
  marks  integer
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
-- Create/Recreate primary, unique and foreign key constraints 
alter table STUDENTS
  add constraint STUDENTS_PK primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255;
  ---------------------------------------------------------
CREATE SEQUENCE sq_students
  MINVALUE 1
  MAXVALUE 999999999999999999999999999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
  ---------------------------------------------------------
insert into students s
(s.id, s.name, s.marks)
values
--(sq_students.nextval, 'Ashley', 81);
--(sq_students.nextval, 'Samantha', 75);
--(sq_students.nextval, 'Julia', 76);
(sq_students.nextval, 'Belvet', 84);
