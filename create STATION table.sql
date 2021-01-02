-- Create table
create table STATION
(
  id     NUMBER not null,
  city   VARCHAR2(21) not null,
  state  VARCHAR2(2) not null,
  lat_n  NUMBER,
  long_w NUMBER
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
alter table STATION
  add constraint STATION_PK primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255;
