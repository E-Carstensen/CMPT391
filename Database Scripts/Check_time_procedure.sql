CREATE PROCEDURE check_time_conflicts
    @studentID int, 
    @courseID int,
    @sectionID int,
    @semester nvarchar(32),
    @year nvarchar(8),
	@timeslotID int

AS 
BEGIN
	IF NOT EXISTS (SELECT *
			FROM Section s 
			INNER JOIN Taken t ON s.courseID = t.courseID
			WHERE t.studentID = @studentID AND s.timeslotID = @timeslotID AND s.sem = @semester AND s.year = @year)
	BEGIN
		return 1
	END
	ELSE
		return -1
	END
