CREATE OR ALTER PROCEDURE add_to_cart
    @studentID int, 
    @courseID int,
    @sectionID int,
    @semester nvarchar(32),
    @year nvarchar(8),
	@timeslotID int

AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION;

			INSERT INTO Taken (studentID, courseID, secID, sem, year, progress) 
			VALUES (@studentID, @courseID, @sectionID, @semester, @year, '1')

            COMMIT TRANSACTION;

		END TRY
		BEGIN CATCH
			-- Rollback if an error occurs
			ROLLBACK TRANSACTION;
				RETURN -1;
			END CATCH
		END