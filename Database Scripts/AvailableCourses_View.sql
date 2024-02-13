ALTER VIEW V_available_classes AS
select C.courseID, c.courseName, s.secID, s.sem, s.year, t.day, t.startTime , t.endTime ,s.cap, s.enrolled, (i.fName+ ' ' + i.lName) as Instructor_Name
from Course c, Section s, Timeslot t, Teaches th, Instructor i
where c.courseID = s.courseID 
AND th.courseID = c.courseID
AND s.timeslotID = t.timeslotID 
AND th.instructorID = i.instructorID


