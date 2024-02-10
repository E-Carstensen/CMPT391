CREATE PROCEDURE show_enrolled_classes
    @username int,
    @sem NVARCHAR(32),
	@year NVARCHAR(8)
AS
BEGIN
   (SELECT c.courseName, t.sem, t.year FROM Course c, Taken t 
   WHERE   t.studentID = @username 
   AND t.sem = @sem 
   AND t.year = @year)
   
   
   
END




