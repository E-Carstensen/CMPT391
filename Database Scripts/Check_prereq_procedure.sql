CREATE PROCEDURE check_prereq
    @studentID int, 
    @courseID int,
    @sectionID int,
    @semester nvarchar(32),
    @year nvarchar(8),
	@timeslotID int

AS 
BEGIN
	-- Check if there is a prerequisite for the course --
	IF EXISTS (SELECT * FROM PreReq WHERE courseID = @courseID)
	BEGIN
		IF EXISTS (SELECT *
			FROM Taken t
			INNER JOIN PreReq pr ON t.courseID = pr.prereqID
			WHERE t.studentID = @studentID AND pr.courseID = @courseID AND t.progress = 3)
			BEGIN
				return 1
			END
			ELSE
		return -1
	END
	ELSE
	return 1
END

			