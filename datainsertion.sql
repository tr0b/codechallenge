/*
*
* Coding Challenge
* SQL Server Data Insertion Query
* Warning: Be sure to first run the table creation query provided in the repository prior to running the Data Insertion Query
*
*/
USE dbCodingChallenge
GO
INSERT into dbo.tbUser values
('John', 'Doe'),
('Jane', 'Doe'),
('Jack','Doe')
GO
INSERT into dbo.tbProject values 
(DEFAULT, DEFAULT, 2),
(DEFAULT, DEFAULT, 4),
(DEFAULT, DEFAULT, 6),
(DEFAULT, DEFAULT, 7),
(DEFAULT, DEFAULT, 8),
(DEFAULT, DEFAULT, 12),
(DEFAULT, DEFAULT, 13),
(DEFAULT, DEFAULT, 14),
(DEFAULT, DEFAULT, 18),
(DEFAULT, DEFAULT, 19),
(DEFAULT, DEFAULT, 20),
(DEFAULT, DEFAULT, 21),
(DEFAULT, DEFAULT, 22),
(DEFAULT, DEFAULT, 24),
(DEFAULT, DEFAULT, 25)
GO

INSERT into dbo.tbUserProject values 
(1,1,1, 2020-02-04),
(1,2,0,DEFAULT),
(1,3,1,2020-03-04),
(1,4,0,2020-02-06),
(1,5,1,2020-02-05),
(2,6,1,2021-02-04),
(2,7,0,2020-07-08),
(2,8,0,2020-02-09),
(2,9,0,2020-02-10),
(2,10,0,2020-02-11),
(3,11,1,2020-06-11),
(3,12,1,2020-10-04),
(3,13,1,DEFAULT),
(3,14,0,DEFAULT),
(3,15,1,DEFAULT)
GO
SELECT * FROM dbo.tbProject
SELECT * FROM dbo.tbUser
SELECT * FROM dbo.tbUserProject