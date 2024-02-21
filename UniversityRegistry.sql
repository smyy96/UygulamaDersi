create database UniversityRegistry
go

use UniversityRegistry
go



CREATE TABLE Faculty (
    FacultyID INT PRIMARY KEY IDENTITY,
    FacultyName NVARCHAR(50) NOT NULL
)
GO



CREATE TABLE Department (

    DepartmentID INT PRIMARY KEY IDENTITY,
    FacultyID INT FOREIGN KEY REFERENCES Faculty(FacultyID),
    DepartmentName NVARCHAR(50) NOT NULL
    
)
GO



CREATE TABLE Lessons (
    LessonsID INT PRIMARY KEY IDENTITY,
    DepartmentID INT  FOREIGN KEY REFERENCES Department(DepartmentID),
    LessonName NVARCHAR(50) NOT NULL   
)
GO

CREATE TABLE Advisor (  --fakultede eklenmeli bence
    AdvisorID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100),
    InternalNo TINYINT
)
GO


CREATE TABLE Student (
    OgrID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100),
    AdvisorID INT FOREIGN KEY REFERENCES Advisor(AdvisorID),
	FacultyID INT  FOREIGN KEY REFERENCES Faculty(FacultyID),
	--DepartmanID INT  FOREIGN KEY REFERENCES Department(DepartmentID)
)



CREATE TABLE Exams (
    ExamID INT PRIMARY KEY IDENTITY,
    OgrID INT FOREIGN KEY REFERENCES Student(OgrID),
    Midterm1 INT DEFAULT 0,
    Midterm2 INT DEFAULT 0,
    Midterm3 INT DEFAULT 0,
    Final1 INT DEFAULT 0,
    Final2 INT DEFAULT 0,
    Final3 INT DEFAULT 0    
)
GO



CREATE TABLE StudentPhone (
    PhoneID INT PRIMARY KEY IDENTITY,
    OgrID INT FOREIGN KEY REFERENCES Student(OgrID),
    PhoneNumber NVARCHAR(15) NOT NULL
)
GO


INSERT INTO Faculty (FacultyName)
VALUES 
    ('Science'),
    ('Engineering'),
    ('Law'),
    ('Economics')
GO


INSERT INTO Department (FacultyID, DepartmentName)
VALUES 
    (1,'Mathematic'),
    (2,'Electric'),
    (3,'Public Law'),
    (4,'Business'),
    (1,'Physics')
	GO

INSERT INTO Lessons (DepartmentID, LessonName)
VALUES 
    (1, 'M101'),
    (1, 'M102'),
    (1, 'M103'),
    (2, 'E101'),
    (2, 'E201'),
    (2, 'E202')
	GO




	
INSERT INTO Advisor (Name, Surname, Email, InternalNo)
VALUES 
    ('Wendy','Piper', 'wendy.piper@mail.com', 150),
    ('Faith','Lewis', 'faith.lewis@mail.com', 160),
    ('Joan','Pullman', 'joan.pullman@mail.com', 170),
    ('Megan','Cornish', 'megan.cornish@mail.com', 180)
	GO



INSERT INTO Student (Name, Surname, Email, AdvisorID, FacultyID)
VALUES 
    ('Luke', 'Black', 'luke.black@mail.com', 1, 1),
    ('Nicholas', 'Cameron', 'nicholas.cameron@mail.com', 2, 2)
	GO

	

INSERT INTO Exams (OgrID, Midterm1, Midterm2, Midterm3, Final1, Final2, Final3)
VALUES 
    (1, 50, 65, 75, 90, 85, 90),
    (2, 40, 35, 45, 80, 55, 30)
    --(3, 10, 35, 85, 85, 55, 45),
    --(4, 20, 45, 75, 70, 85, 50)
GO



INSERT INTO StudentPhone (OgrID, PhoneNumber)
VALUES 
    (1, '333-44-55'),
    (1, '222-33-44'),
    (2, '111-33-55')
	GO