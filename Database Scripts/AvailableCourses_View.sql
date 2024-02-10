CREATE VIEW V_avaiable_classes AS
select C.courseID, c.courseName, s.secID, s.sem, s.year, t.day, t.startTime , t.endTime 
from Course c, Section s, Timeslot t 
where c.courseID = s.courseID 
AND s.timeslotID = t.timeslotID 