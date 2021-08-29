Create database company1
Create  table PsDetails1 (Personid int,Firstname varchar(20), lastname varchar(10),Gender varchar(10),Dateofbirth int,
                         Nationality varchar(100),Maritualstatus varchar(10),Primaryemailid varchar(200),Primaryphoneno int,
						Secondaryemailid varchar(200),Secondaryphoneno int);
select * from PsDetails1;
 insert into PsDetails1 values(1,'qlk','aaa','m',8-12-2018,'in','s','abc@gmail.com',98877666,'xyz@gamil.com',8665266);
 insert into PsDetails1 values(2,'sa','pp','f',5-1-2011,'in','m','ac@gmail.com',98877123,'x@gamil.com',8665223);
 insert into PsDetails1 values(3,'jh','uu','m',1-6-2011,'in','m','ee@gmail.com',87667667,'oon@gamil.com',988773);
 insert into PsDetails1 values(4,'tt','cd','f',3-5-2011,'pak','s','kk@gmail.com',7745556,'add@gamil.com',866566);
 insert into PsDetails1 values(5,'we','nj','m',2-9-2011,'goa','m','sc@gmail.com',8766687,'qww@gamil.com',9434445);

  delete  from  PsDetails1 where  Firstname ='sai';