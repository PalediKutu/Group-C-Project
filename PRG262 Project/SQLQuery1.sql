CREATE DATABASE PatientsDB;

USE [School Data];

CREATE TABLE tblPatient (
    StudentNumber INT PRIMARY KEY,
    StudentName VARCHAR(50),
   StudentSurname VARCHAR(50),
    StudentImage image,
   DOB date,
   Gender VARCHAR(50),
   PhoneNumber VARCHAR(50),
   sAddress varchar(100),
   CourseCode varchar(50)


);

INSERT INTO StudentInfo (StudentNumber, StudentName, StudentSurname, StudentImage, PhoneNumber,DOB,Gender,PhoneNumber,sAddress,CourseCode)



