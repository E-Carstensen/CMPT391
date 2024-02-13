CREATE OR ALTER PROCEDURE edit_user
	@username int,
	@firstName NVARCHAR(64),
	@lastName NVARCHAR(128),
	@phone NVARCHAR(13),
	@email NVARCHAR(128),
	@password NVARCHAR(128)
AS
BEGIN
	UPDATE Student
	SET  fName = @firstName, 
		lName = @lastName,
		phone = @phone, 
		email = @email, 
		password = @password
	WHERE studentID = @username

	IF @@ROWCOUNT > 0
	BEGIN
		RETURN 1
	END
	ELSE
	BEGIN
		RETURN 0
	END
END