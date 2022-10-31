CREATE DATABASE ST_LOGIN;

CREATE  TABLE Students
(
StudentId INT PRIMARY KEY,
NAME VARCHAR(50) ,
Age int,
PresentAddress NVARCHAR(50),
ParmanentAddress NVARCHAR(50),
Department  NVARCHAR(50),
Religion NVARCHAR(50),
PhoneNumber NVARCHAR(50),
BloodGroup NVARCHAR(50)

);

SELECT * FROM Students;
DELETE FROM Students  WHERE StudentId = ' ';

