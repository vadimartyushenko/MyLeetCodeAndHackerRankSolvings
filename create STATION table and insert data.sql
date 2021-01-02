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
---------------------------------------------------------
CREATE SEQUENCE sq_station
  MINVALUE 1
  MAXVALUE 999999999999999999999999999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
---------------------------------------------------------
insert into station s
(s.id, s.city, s.state)
values
--(sq_station.nextval, 'New York', 'NY');
--(sq_station.nextval, 'Los Angeles', 'CA');
--(sq_station.nextval, 'Chicago', 'IL');
--(sq_station.nextval, 'Houston', 'TX');
--(sq_station.nextval, 'Phoenix', 'AZ');
--(sq_station.nextval, 'Philadelphia', 'PA');
--(sq_station.nextval, 'San Antonio', 'TX');
--(sq_station.nextval, 'San Diego', 'CA');
(sq_station.nextval, 'Dallas', 'TX');
