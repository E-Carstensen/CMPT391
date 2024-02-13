CREATE OR ALTER PROCEDURE show_user
	@username int
AS
BEGIN
	(SELECT studentID, fName, lName, phone, email, password, active FROM Student
	WHERE studentID = @username)
END