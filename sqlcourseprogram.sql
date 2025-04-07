CREATE DATABASE COURSEPROGRAM;

Create Table Student (
StudentId int,
StudentName varchar (255),
City varchar (255),
CourseId int,
CourseName varchar (255),
LectureName varchar (255)
);

Create Table Course (
CourseId int,
CourseName varchar (255),
LectureName varchar (255)
);

Create Table Lecture (
LectureId int,
LectureName varchar (255),
CourseId int,
CourseName varchar (255)
);

Create Table Signup(
UserId int NOT NULL PRIMARY KEY,
UserName varchar (255) NOT NULL,
Password varchar (50)
);

INSERT INTO Student
(StudentId, StudentName, City, CourseId, CourseName, LectureName)
VALUES(1, 'Kasun Gamage', 'Kandy', 2, 'Graphic Design', 'J.S.V.Piyasena'),
      (2, 'Daniel Sam', 'Jaffna', 3, 'Mobile App Development', 'K.K.Dias'),
	  (3, 'Hansi Silva', 'Colombo', 1, 'Web Development', 'M.M.Herath'),
	  (4, 'Ranidu  Herath', 'Matara', 3, 'Mobile App Development', 'K.K.Dias'),
	  (5, 'Praneeth Wijesinghe', 'Kandy', 4, 'Java', 'U.H.S.Perera'),
	  (6, 'Nuwani Herath', 'Rathnapura', 1, 'Web Development', 'M.M.Herath');


INSERT INTO Course
(CourseId, CourseName, LectureName)
VALUES(1, 'Web Development', 'M.M.Herath'),
	  (2, 'Graphic Design', 'J.S.V.Piyasena'),
	  (3, 'Mobile App Development', 'K.K.S.Dias'),
	  (4, 'Java', 'U.H.S.Perera');


INSERT INTO Lecture
(LectureId, LectureName, CourseId, CourseName)
VALUES(025, 'M.M.Herath', 1, 'Web Development'),
      (026, 'J.S.V.Piyasena', 2, 'Graphic Design'),
	  (027, 'K.K.S.Dias', 3, 'Mobile App Development'),
	   (028, 'U.H.S.Perera', 4, 'Java');

INSERT INTO Signup
(UserId, UserName, Password)
VALUES(100, 'Nirosha','abc'),
      (101, 'Sam', '123'),
	  (102, 'Kasun', 'cd2');



SELECT * FROM Student;

SELECT StudentId, StudentName, City FROM Student WHERE City='Kandy';

UPDATE Student SET City='Glle' WHERE StudentId='4';

SELECT * FROM Student;


SELECT CourseName, StudentId, StudentName, City, CourseId, LectureName FROM Student;