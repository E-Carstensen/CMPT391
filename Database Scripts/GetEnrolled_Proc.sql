AlTER PROCEDURE show_enrolled_classes
    @username int,
    @sem NVARCHAR(32),
	@year NVARCHAR(8)
AS
BEGIN
   (SELECT c.courseName, t.sem, t.year, s.secID, ts.day, ts.startTime, ts.endTime
   FROM Course c, Taken t, Section s, Timeslot ts
   WHERE   t.studentID = @username 
   AND t.courseID = c.courseID
   AND t.secID = s.secID
   AND s.timeslotID = ts.timeslotID
   AND UPPER(t.sem) = UPPER(@sem)
   AND t.year = @year)
   
   
   
END


