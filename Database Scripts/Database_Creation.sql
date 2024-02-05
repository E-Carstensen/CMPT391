
create TABLE [Student] (
  [studentID] integer PRIMARY KEY,
  [fName] nvarchar(64),
  [lName] nvarchar(128),
  [phone] nvarchar(13),
  [email] nvarchar(128),
  [password] nvarchar(128)
)
GO

CREATE TABLE [Instructor] (
  [instructorID] integer PRIMARY KEY,
  [fName] nvarchar(64),
  [lName] nvarchar(128),
  [dName] nvarchar(128),
  [phone] nvarchar(24),
  [email] nvarchar(128)
)
GO


CREATE TABLE [Department] (
  [dName] nvarchar(128) PRIMARY KEY,
  [headID] integer
)
GO

CREATE TABLE [Course] (
  [courseID] integer PRIMARY KEY,
  [courseName] nvarchar(128),
  [meetingTime] time,
  [departmentName] nvarchar(128)
)
GO

CREATE TABLE [Taken] (
  [studentID] integer,
  [courseID] integer,
  [secID] integer,
  [sem] nvarchar(32),
  [year] nvarchar(8),
  PRIMARY KEY ([studentID], [courseID], [secID], [sem], [year])
)
GO

CREATE TABLE [Teaches] (
  [instructorID] integer,
  [courseID] integer,
  [secID] integer,
  [sem] nvarchar(32),
  [year] nvarchar(8),
  PRIMARY KEY ([instructorID], [courseID], [secID], [sem], [year])
)
GO

CREATE TABLE [PreReq] (
  [courseID] integer,
  [prereqID] integer,
  PRIMARY KEY ([courseID], [prereqID])
)
GO

CREATE TABLE [Timeslot] (
  [timeslotID] integer PRIMARY KEY,
  [day] nvarchar(32),
  [startTime] time,
  [endTime] time
)
GO

CREATE TABLE [Section] (
  [secID] integer,
  [sem] nvarchar(32),
  [year] nvarchar(8),
  [cap] integer,
  [enrolled] integer,
  [timeslotID] integer,
  PRIMARY KEY ([secID], [sem], [year])
)
GO

ALTER TABLE [Course] ADD FOREIGN KEY ([departmentName]) REFERENCES [Department] ([dName])
GO

ALTER TABLE [Department] ADD FOREIGN KEY ([headID]) REFERENCES [Instructor] ([instructorId])
GO

ALTER TABLE [Instructor] ADD FOREIGN KEY ([dName]) REFERENCES [Department] ([dName])
GO

ALTER TABLE [preReq] ADD FOREIGN KEY ([courseID]) REFERENCES [Course] ([courseID])
GO

ALTER TABLE [prereq] ADD FOREIGN KEY ([prereqID]) REFERENCES [course] ([CourseID])
GO

ALTER TABLE [Taken] ADD FOREIGN KEY ([studentID]) REFERENCES [Student] ([studentID])
GO

ALTER TABLE [taken] ADD FOREIGN KEY ([courseID]) REFERENCES [course] ([courseID])
GO

ALTER TABLE [Taken] ADD FOREIGN KEY ([secID], [sem], [year]) REFERENCES [Section] ([secID], [sem], [year])
GO


ALTER TABLE [Teaches] ADD FOREIGN KEY ([instructorID]) REFERENCES [Instructor] ([instructorID])
GO

ALTER TABLE [Teaches] ADD FOREIGN KEY ([courseID]) REFERENCES [Course] ([courseID])
GO

ALTER TABLE [Teaches] ADD FOREIGN KEY ([secID], [sem], [year]) REFERENCES [Section] ([secID], [sem], [year]);


ALTER TABLE [Section] ADD FOREIGN KEY ([timeslotID]) REFERENCES [Timeslot] ([timeslotID])
GO

