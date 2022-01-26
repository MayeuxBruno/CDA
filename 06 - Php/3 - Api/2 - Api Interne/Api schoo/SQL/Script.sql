USE school;

CREATE TABLE IF NOT EXISTS utilisateurs (
idUtilisateur int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
nom varchar(50) NOT NULL,
prenom varchar(50) NOT NULL,
adresseMail varchar(50) UNIQUE NOT NULL,
motDePasse varchar(50) NOT NULL,
role int(11) NOT NULL COMMENT '2 Admin 1 User'
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

CREATE TABLE IF NOT EXISTS textes (
idTexte int (11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
codeTexte varchar (50) NOT NULL,
fr LONGTEXT NOT NULL,
en LONGTEXT NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

CREATE VIEW studentsgradescourses 
 AS SELECT s.StudentID, s.Name, g.GradeName
 FROM student as s
 INNER JOIN grade as g on s.GradeId=g.GradeId
 INNER JOIN grade as g on s.GradeId=g.GradeId

 CREATE VIEW studentsgradescourses 
 AS SELECT c.CourseId ,c.courseName, s.Name, g.GradeName
 FROM  studentscourses as sc
 INNER JOIN courses as c on sc.CourseId=c.CourseId
 INNER JOIN student as s on sc.StudentId=s.StudentId
 INNER JOIN grade as g on g.GradeId=s.GradeId
 