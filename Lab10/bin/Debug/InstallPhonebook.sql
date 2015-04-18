USE master

-- If CHDB database exists, drop it
IF NOT EXISTS ( SELECT  * FROM sysdatabases WHERE name = 'Phonebook' )
  CREATE DATABASE Phonebook
GO

IF NOT EXISTS ( SELECT  * FROM sysdatabases WHERE name = 'Phonebook' )
BEGIN
-- Make the CHDB database the current database
USE Phonebook;

-- Create Department table
CREATE TABLE Employee (
	EmployeeId INT NOT NULL IDENTITY,
	Lastname VARCHAR(30) NOT NULL ,
	Firstname VARCHAR(30) NOT NULL ,
	Extension DECIMAL(4,0) NOT NULL ,
	Department VARCHAR(30) NOT NULL,
	CONSTRAINT CK_LastName CHECK(Lastname <> ''),
	CONSTRAINT CK_Firstname CHECK(Firstname <> ''),
	CONSTRAINT CK_Extension CHECK(Extension > 0),
	CONSTRAINT CK_Department CHECK(Department <> ''),
	CONSTRAINT PK_EmployeeId PRIMARY KEY ( EmployeeId ), CHECK(EmployeeId > 0)
);

INSERT INTO Employee VALUES('Holubeshen','Tyler','1905','Engineering')
INSERT INTO Employee VALUES('Kreuger','Freddy','1289','Manufacturing')
INSERT INTO Employee VALUES('Man','Iron','1666','Sales')
INSERT INTO Employee VALUES('Gadget','Inspector','1666','Engineering')
INSERT INTO Employee VALUES('Garcia','Austin','1539','Manufactoring')
INSERT INTO Employee VALUES('Crandel','Jason','1539','Medical')
INSERT INTO Employee VALUES('Clooney','George','1905','Actor')
INSERT INTO Employee VALUES('Depp','Johnny','1289','Actor')
INSERT INTO Employee VALUES('Smith','Will','1666','Business')
INSERT INTO Employee VALUES('Jackson','Curtis','1666','Musician')
INSERT INTO Employee VALUES('Dogg','Snoop','1539','Medical')
INSERT INTO Employee VALUES('Dre','Dr','1539','Medical')
INSERT INTO Employee VALUES('Dre1','Dr','1539','Medical')
INSERT INTO Employee VALUES('Dre2','Dr','1539','Medical')
INSERT INTO Employee VALUES('Dre3','Dr','1539','Medical')

CREATE TABLE Departments (
	DepartmentId INT NOT NULL IDENTITY,
	DepartmentName VARCHAR(30) NOT NULL ,
	CONSTRAINT CK_DepartmentName CHECK(DepartmentName <> ''),
	CONSTRAINT PK_DepartmentId PRIMARY KEY ( DepartmentId ), CHECK(DepartmentId > 0)
);

INSERT INTO Departments VALUES('Manufactoring');
INSERT INTO Departments VALUES('Engineering');
INSERT INTO Departments VALUES('Sales');
INSERT INTO Departments VALUES('Medical');
INSERT INTO Departments VALUES('Administration');
INSERT INTO Departments VALUES('Actor');
INSERT INTO Departments VALUES('Musician');
INSERT INTO Departments VALUES('Business');
END