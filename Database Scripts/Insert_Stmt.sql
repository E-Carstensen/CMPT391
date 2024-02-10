use CMPT391Database

insert into dbo.Student
values (007, 'Jerome', 'Onil', 780, 'j@gmail.com', 'HalaMadrid', 'true')

insert into dbo.Instructor
values(9,'Haj', 'El','CompSci','780', 'elhaj')

insert into dbo.Department
values('CompSci',9)

insert into dbo.Course
values(123,'CMPT 391', 'CompSci')

insert into dbo.Timeslot 
values (001, 'Monday',' 07:30', '08:30')

insert into dbo.Section
values (123,001, 'Fall', '2023', 30, 10, 002)

insert into dbo.Taken
values(007, 123,001, 'Fall', '2023',1)

insert into dbo.Timeslot 
values (002, 'Monday',' 10:30', '11:50')


select C.courseID, c.courseName, s.secID, s.sem, s.year, t.day, t.startTime , t.endTime 
from Course c, Section s, Timeslot t 
where c.courseID = s.courseID AND s.timeslotID = t.timeslotID 

