use inventory;

create table powertools
(ProductId int(10),
Name varchar(40), 
Category varchar(30),
Brand varchar(30),
Quantity int(10),
Price double,
Description varchar(300),
Discount int(10),
Rating double,
RatingCount int(10),
VendorName varchar(30),
VendorQuantity int(10),
ImagePath varchar(30),
primary key(ProductId) 
);


create table saleinv
(SaleInvNumber int(10),
ProductId int(10),
PricePerUnit double,
Quantity int(10),
primary key(SaleInvNumber),
foreign key(ProductId) references powertools(ProductId)
);


/*saws*/
insert into powertools values(1001,'Double Bevel Mitre Saw','Saw','DeWalt',8,799,
'The integrated XPS cross cut positioning system on this DeWalt Double Bevel Sliding 
Compound Miter Saw provides an adjustment-free cut line for better accuracy and visibility',
20,4.8,68,'Industrial Corp',30,'1001.jpg');

insert into powertools values(1002,'Job Site Table Saw','Saw','DeWalt',11,349,
'The DeWalt Job Site Table Saw features a 15 amp motor that quickly rips through hardwoods 
with total ease and the 16-inches of rip easily cuts a variety of larger shelving and trim 
materials.',
0,3.4,10,'Tool Company',50,'1002.jpg');

insert into powertools values(1003,'Compound Mitre Saw','Saw','Ryobi',22,159,
'The Ryobi 10-inch Compound Miter Saw comes equipped with the Exactline laser alignment 
system to produce the most accurate cuts time after time',
14,5,5,'Tool Company',100,'1003.jpg');

insert into powertools values(1004,'Circular Saw','Saw','Milwaukee',5,129,
'Milwaukee\'s M18Circular Saw is designed to provide powerful, lightweight cutting for a variety 
of applications including plumbing, electrical, framing, finishing and carpentry',
0,4.1,6,'Power Tool Inc',75,'1004.jpg');

insert into powertools values(1005,'Variable Speed Jig Saw','Saw','Bosch',7,269,
'The Bosch Barrel Grip Jig Saw delivers both power and total accuracy in your cuts',
0,2.5,16,'Industrial Corp',150,'1005.jpg');





/*drills*/
insert into powertools values(1006,'Hammer Drill','Drill','Milwaukee',40,49.99,
'For contractors, maintenance technicians, remodelers or anyone seeking portability and 
performance, the compact M12 cordless hammer drill/driver gets the job done',
50,3.4,32,'Equipment Needs',25,'1006.jpg');

insert into powertools values(1007,'Lithium-Ion Drill','Drill','Dewalt',2,129.99,
'The DeWalt Lithium-Ion Cordless Drill/Driver kit is designed with a high performance motor 
that delivers 300 unit W out (UWO) of power and offers the ability to complete a wide range of applications',
5,4,25,'Tool Company',75,'1007.jpg');


insert into powertools values(1008,'Bulldog Extreme Rotary Hammer Drill','Drill','Bosch',13,299,
'The fastest, longest lasting breed of rotary hammer, the totally redesigned bulldog extreme outlasts
 the competition in both speed and performance!',
0,3.3,5,'Power Tool Inc',50,'1008.jpg');

insert into powertools values(1009,'Variable Speed Corded Drill','Drill','Ryobi',21,52.98,
'The Ryobi 3/8-inch corded drill/driver features a 4.5 amp motor that offers up to 1,600 RPM for powerful 
drilling and driving in a variety of materials.',
10,1,6,'Power Tool Inc',175,'1009.jpg');

insert into powertools values(1010,'Cordless Hammer Drill','Drill','Milwaukee',50,379,
'Milwaukee\'s M18 Cordless Hammer Drill Driver Kit provides a high power motor that delivers 650 inch lbs. of torque',
0,4.6,4,'Industrial Corp',20,'1010.jpg');




/*sander*/
insert into powertools values(1011,'Palm-Grip Random Orbit Sander','Sander','Bosch',30,89,
'This Bosch 5-inch Palm-Grip Random Orbit Sander can traps dust particles as small as a 1/2 micron in diameter',
0,3.7,35,'Tool Company',200,'1011.jpg');

insert into powertools values(1012,'Sheet Palm-Grip Sander','Sander','Dewalt',19,69.98,
'DeWalt\'s 1/4 Sheet Palm Grip Sander features a 2.4 amp motor that can sand at 14,000 OPM, providing a superior 
finish, as well as a textured anti-slip top and body grip',
0,2.9,3,'Equipment Needs',180,'1012.jpg');

insert into powertools values(1013,'Random Orbit Palm Sander','Sander','Milwaukee',27,78,
'Milwaukee\'s 1/4 Sheet Random Orbit Palm Sander features a 3.0 amp permanent magnet motor with 
14,000 orbits per minute.',
25,3.9,29,'Equipment Needs',10,'1013.jpg');

insert into powertools values(1014,'Finish Sander','Sander','Ryobi',3,55.99,
'The Ryobi 1/4-Sheet Pad Sander features a 2 amp ball-bearing motor and 14,000 orbits per minute for a powerful and fast 
performance that can stand up to a wide variety of sanding applications',
0,1.5,44,'Industrial Corp',35,'1014.jpg');

insert into powertools values(1015,'Detail Sander','Sander','Ryobi',8,33,
'The Ryobi Detail Sander sands, scrapes, buffs, cleans, polishes and removes rust from a wide variety of materials',
10,4.7,50,'Tool Company',50,'1015.jpg');



/*grinders*/
insert into powertools values(1016,'Angle Grinder','Grinder','Bosch',9,449,
'The Bosch CAG180-01 18V 4-1/2 In. Angle Grinder is a cordless angle grinder that can handle professional applications',
0,5,1,'Power Tool Inc',100,'1016.jpg');

insert into powertools values(1017,'Smalll Angle Grinder','Grinder','Milwaukee',22,179.99,
'The 13 amp 6-inch Small Angle Grinder delivers up to 30% more durability and power than the competition.',
0,5,4,'Industrial Corp',120,'1017.jpg');

insert into powertools values(1018,'Die Grinder','Grinder','Bosch',10,249,
'High performance four-pole motor - delivers best-in-class power-to-weight ratio',
40,3,13,'Industrial Corp',90,'1018.jpg');

insert into powertools values(1019,'Cut-Off Tool','Grinder','Dewalt',20,179,
'The DCG412B 20V MAX* Lithium Ion 4 1/2-inch Cut Off Tool (Tool Only) is ideal for a wide range of construction, 
maintenance, repair and automotive applications',
0,4.2,23,'Tool Company',15,'1019.jpg');

insert into powertools values(1020, 'Bench Grinder','Grinder','Ryobi',31,66.97,
'The Ryobi 6-inch Bench Grinder features a 2.1 amp induction motor for dependable operation, a heavy gauge steel 
base that reduces vibration and improves stabilitys',
0,4,1,'Equipment Needs',5,'1020.jpg');

