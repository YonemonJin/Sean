-- create database cs2dbase; 
create table  vehicleinfo( 
vId int not null primary key auto_increment, 
vType varchar(150), 
plateNo varchar(25), 
vModel varchar(150)); 
insert into vehicleinfo(vType,plateNo,vModel) 
values ('ambulance','cag456','toyota');
select * from vehicleinfo