# 20강 행 개수 구하기 Count

CREATE DATABASE `Bookdb`;
CREATE TABLE `sample51`(
	`no`	 		INT PRIMARY KEY,
	`name`		VARCHAR(10),
	`quantity`	INT 
);

SELECT * FROM sample51;

INSERT INTO sample51 VALUES(1,'a',1);
INSERT INTO sample51 VALUES(2,'a',2);
INSERT INTO sample51 VALUES(3,'b',10);
INSERT INTO sample51 VALUES(4,'c',3);
INSERT INTO sample51(`no`) VALUES(5);

SELECT COUNT(*) FROM sample51;
SELECT COUNT(*) FROM sample51 WHERE NAME = 'a';
SELECT COUNT(`no`), COUNT(`name`) FROM sample51; 
SELECT ALL `name` FROM sample51;
SELECT DISTINCT `name` FROM sample51;
SELECT COUNT(ALL `name`), COUNT(DISTINCT `name`) FROM sample51;
SELECT COUNT(ALL `name`) FROM sample51;

#21강 SUM,AVG,Min,Max

SELECT SUM(quantity) FROM sample51;
SELECT AVG(quantity),SUM(quantity)/COUNT(quantity) FROM sample51;

SELECT MIN(quantity),MAX(quantity),MIN(NAME),MAX(NAME) FROM sample51;

#22강 group by
SELECT * FROM sample51;
SELECT `name` FROM sample51 GROUP BY `name`;
SELECT `name`,COUNT(NAME), SUM(quantity) FROM sample51 GROUP BY `name`;

SELECT `name`, COUNT(`name`) FROM sample51
GROUP BY `name` HAVING COUNT(`name`) =1;