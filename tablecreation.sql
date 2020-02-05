/*
*
* Coding Challenge
* SQL Server Table Creation Query
* 
*
*/
USE MASTER
GO
IF ( EXISTS ( SELECT * FROM SYSDATABASES WHERE name = 'dbCodingChallenge'))
	DROP DATABASE dbCodingChallenge
	/*
	*
	*
	If dbCodingChallenge already exists under the host's system databases, then it will be dropped and created immediately afterwards
	*
	*/
GO
Create DATABASE dbCodingChallenge
GO
USE dbCodingChallenge
GO

/***
*
*Table Creation
*
****/

CREATE TABLE tbUser(
/*Table User*/
	PK_UserID INT PRIMARY KEY NOT NULL IDENTITY (1,1), --Primary Key User ID. AUTO-INCREMENT ENABLED
	First_Name VARCHAR(50) NOT NULL, --First name
	Last_Name VARCHAR(50) NOT NULL --Last Name
)
GO
CREATE TABLE tbProject(
/*Table Project*/
	PK_ProjectID INT PRIMARY KEY NOT NULL IDENTITY (1,1), --Primary Key Project ID AUTO-INCREMENT ENABLED
	StartDate DATETIME NOT NULL DEFAULT GETDATE(), --Start date
	EndDate DATETIME NOT NULL DEFAULT GETDATE() +7 , -- End date
	Credits INT NOT NULL -- Credits
)
GO
CREATE TABLE tbUserProject(
/*Table UserProject*/
	PK_UserProject INT PRIMARY KEY IDENTITY(1,1),
	FK_UserID INT, --Foreign Key User ID
	FK_ProjectID INT, --Foreign Key Project ID
	isActive BIT NOT NULL, --Is Active Bit 
	AssignedDate DATETIME DEFAULT GETDATE(), --Assigned Date
	FOREIGN KEY (FK_UserID) REFERENCES tbUser(PK_UserID), --Foreign Key References for FK_UserID in the table tbUser
	FOREIGN KEY (FK_ProjectID) REFERENCES tbProject(PK_ProjectID) --Foreign Key References for FK_ProjectID in the table tbUser
)
GO

