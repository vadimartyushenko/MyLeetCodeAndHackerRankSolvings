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
