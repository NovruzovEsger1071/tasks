CREATE DATABASE COURSE
USE COURSE

CREATE TABLE Students (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) DEFAULT 'xxx',
    Age INT NOT NULL,
    Point INT NOT NULL
);

INSERT INTO Students (Name, Surname, Age, Point)
VALUES 
('Esger', 'Novruzov', 20, 88),
('Emil', 'Tahirov', 31, 75),
('Adam', 'Adamov', 72, 33);

INSERT INTO Students (Name, Age, Point)
VALUES 
('Esgerin1', 21, 88),
('Esgerin2', 20, 92);

SELECT * FROM Students;

UPDATE Students
SET Surname = 'UpdatedSurname'
WHERE Surname = 'xxx';

UPDATE Students
SET Point = 100
WHERE Id = 1;

SELECT * FROM Students
WHERE Point BETWEEN 70 AND 90;

SELECT * FROM Students
ORDER BY Point DESC;

SELECT Name, Surname FROM Students
WHERE Age < 21;

ALTER TABLE Students
ADD AvaregePoint INT CHECK (AvaregePoint BETWEEN 0 AND 100);