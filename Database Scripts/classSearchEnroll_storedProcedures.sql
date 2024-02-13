use CMPT391Database
go



CREATE PROCEDURE enroll_class
    @studentID int, 
    @courseID int,
    @sectionID int,
    @semester nvarchar(32),
    @year nvarchar(8)
AS 
BEGIN 
    -- Check if the student is already enrolled in the specified class
    IF EXISTS (SELECT 1 FROM Taken t WHERE t.studentID = @studentID AND t.courseID = @courseID AND t.secID = @sectionID AND t.sem = @semester AND t.year = @year)
    BEGIN
        BEGIN TRY
            BEGIN TRANSACTION;

            -- Get the current enrollment and capacity of the section
            DECLARE @enrolled int;
            DECLARE @capacity int;
            SELECT @enrolled = s.enrolled, @capacity = s.cap
            FROM Section s
            WHERE s.courseID = @courseID AND s.secID = @sectionID AND s.sem = @semester AND s.year = @year;

            IF @enrolled < @capacity
            BEGIN
                -- Update the status of the existing enrollment
                UPDATE Taken
                SET progress = 2
                WHERE studentID = @studentID AND courseID = @courseID AND secID = @sectionID AND sem = @semester AND year = @year AND progress = 1;

                -- Increment the enrollment count for the section
                UPDATE Section
                SET enrolled = @enrolled + 1
                WHERE courseID = @courseID AND secID = @sectionID AND sem = @semester AND year = @year;

                COMMIT TRANSACTION;
            END
            ELSE
            BEGIN
                -- Rollback if the section is already at full capacity
                ROLLBACK TRANSACTION;
                RETURN -2;
            END
        END TRY
        BEGIN CATCH
            -- Rollback if an error occurs
            ROLLBACK TRANSACTION;
            RETURN -3;
        END CATCH
    END
    ELSE
    BEGIN 
        -- Return -1 if the student is not enrolled in the specified class
        RETURN -1;
    END
END
go



CREATE PROCEDURE show_classes
    @courseName int, 
    @sem nvarchar(32),
    @year nvarchar(8)
AS 
BEGIN 
	select * from Section s, Course c WHERE s.courseID = c.courseID AND c.courseName like '%' + @courseName + '%' AND s.sem = @sem AND s.year = @year;
END
