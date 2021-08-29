create database Companydetails1;
create table Companydetails(
Sno int Identity(1,1) primary key,
Companyname varchar(500),
Yearsofexp int,
Techonologies varchar(100),
Date date,
Jobapplicants int,
Phonenum varchar(400),
Location varchar(200),
Openings int,
Links varchar(500));

select * from Companydetails;

insert into Companydetails values('TCS',2,'Dotnet','2-3-2021',3,'9876543210',
                                   'pune',10,'http//www.tcs')

								   
insert into Companydetails values('Ibm',2,'Fullstack','2-8-2020',6,'8718887820',
                                   'Hyd',20,'http//www.ibm')

insert into Companydetails values('Tech',3,'Python','1-9-2021',8,'9086446573',
                                   'delhi',15,'http//www.tech')

insert into Companydetails values('Wipro',1,'MVC','7-4-2019',15,'7976446573',
                                   'chennai',20,'http//www.wipro')

insert into Companydetails values('Capgi',3,'React','3-8-2020',10,'9867446573',
                                   'bnglr',30,'http//www.capgi')

								   
