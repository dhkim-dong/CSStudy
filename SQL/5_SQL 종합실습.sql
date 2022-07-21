#날짜 : 2022/07/20
#이름 : 김동훈
#내용 : SQL 종합실습


#실습 5-1 
CREATE DATABASE `SaleDB`;
CREATE USER 'manager'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON SaleDB.* TO 'manager'@'%';
FLUSH PRIVILEGES;

#실습 5-2
CREATE TABLE `Member`(
	`uid`		VARCHAR(10) PRIMARY KEY,
	`name`	VARCHAR(10) NOT NULL,
	`hp`		CHAR(13)	NOT NULL UNIQUE,
	`pos`		VARCHAR(10) NOT NULL,
	`dep`		INT,
	`rdate`	DATETIME NOT NULL 
);

SELECT * FROM `Member`;

CREATE TABLE `Department`(
	`depNo`		INT PRIMARY KEY,
	`name`		VARCHAR(10) NOT NULL,
	`tel`			CHAR(12) NOT NULL
);

SELECT * FROM `Department`;

CREATE TABLE `Sales`(
	`seq`		INT AUTO_INCREMENT PRIMARY KEY,
	`uid`		VARCHAR(10) NOT NULL,
	`year`	YEAR NOT NULL,
	`month`	INT NOT NULL,
	`sale`	INT NOT NULL 
);
SELECT * FROM `Sales`;
#실습 5-3
INSERT INTO `Member` VALUES('a101','박혁거세','010-1234-1001','부장','101','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a102','김유신','010-1234-1002','차장','101','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a103','김춘추','010-1234-1003','사원','101','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a104','장보고','010-1234-1004','대리','102','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a105','강감찬','010-1234-1005','과장','102','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a106','이성계','010-1234-1006','차장','103','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a107','정철','010-1234-1007','차장','103','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a108','이순신','010-1234-1008','부장','104','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a109','허균','010-1234-1009','부장','104','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a110','정약용','010-1234-1010','사원','105','2020-11-19 11:39:48');
INSERT INTO `Member` VALUES('a111','박지원','010-1234-1011','사원','105','2020-11-19 11:39:48');

INSERT INTO `Department` VALUES('101','영업1부','051-512-1001');
INSERT INTO `Department` VALUES('102','영업2부','051-512-1002');
INSERT INTO `Department` VALUES('103','영업3부','051-512-1003');
INSERT INTO `Department` VALUES('104','영업4부','051-512-1004');
INSERT INTO `Department` VALUES('105','영업5부','051-512-1005');
INSERT INTO `Department` VALUES('106','영업지원부','051-512-1006');
INSERT INTO `Department` VALUES('107','인사부','051-512-1007');

INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a101',2018,1,98100);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a102',2018,1,136000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a103',2018,1,80100);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a104',2018,1,78000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a105',2018,1,93000);

INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a101',2018,2,23500);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a102',2018,2,126000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a103',2018,2,18500);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a105',2018,2,19000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a106',2018,2,53000);

INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a101',2019,1,24000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a102',2019,1,109000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a103',2019,1,101000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a104',2019,1,53500);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a107',2019,1,24000);

INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a102',2019,2,160000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a103',2019,2,101000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a104',2019,2,43000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a105',2019,2,24000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a106',2019,2,109000);

INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a102',2020,1,201000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a104',2020,1,63000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a105',2020,1,74000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a106',2020,1,122000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a107',2020,1,111000);

INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a102',2020,2,120000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a103',2020,2,93000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a104',2020,2,84000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a105',2020,2,180000);
INSERT INTO `Sales`(`uid`,`year`,`month`,`sale`) VALUES('a108',2020,2,76000);

#실습 5-4
SELECT * FROM `Member` WHERE `name` = '김유신';
SELECT * FROM `Member` WHERE `pos`='차장' AND `dep` = '101';
SELECT * FROM `Member` WHERE `name` != '김춘추';
SELECT * FROM `Member` WHERE `name` <> '김춘추';
SELECT * FROM `Member` WHERE `pos` = '사원' OR `pos` = '대리';
SELECT * FROM `Member` WHERE `pos` IN('사원','대리');
SELECT * FROM `Member` WHERE `name` LIKE '%신';
SELECT * FROM `Member` WHERE `name` LIKE '김%';
SELECT * FROM `Member` WHERE `name` LIKE '_성_';
SELECT * FROM `Member` WHERE `name` LIKE '김__';
SELECT * FROM `Member` WHERE `name` LIKE '정_';
SELECT * FROM `Sales` WHERE `sale` > 50000;
SELECT * FROM `Sales` WHERE `sale` >= 50000 AND `sale` < 100000 AND `month` = 1;
SELECT * FROM `Sales` WHERE `sale` BETWEEN 50000 AND 100000;
SELECT *FROM `Sales` WHERE `sale` NOT BETWEEN 50000 AND 100000;
SELECT * FROM `Sales` WHERE `year` IN(2020);
SELECT * FROM `Sales` WHERE `month` IN(1,2);
#실습 5-5
SELECT * FROM `Sales` ORDER BY `sale`;
SELECT * FROM `Sales` ORDER BY `sale` ASC;
SELECT * FROM `Sales` ORDER BY `sale` DESC;
SELECT * FROM `Member` ORDER BY `name`;
SELECT * FROM `Member` ORDER BY `name` ASC;
SELECT * FROM `Member` ORDER BY `name` DESC;
SELECT * FROM `Sales` 
WHERE `sale` > 50000
ORDER BY `year`, `month`,`sale` DESC;
SELECT * FROM `Sales` WHERE `sale` > 50000 ORDER BY `sale` DESC;

#실습 5-6  # limit : 처음부터 N개 출력   limit i,n = i부터 3개 출력
SELECT * FROM `sales` LIMIT 5;  
SELECT * FROM sales LIMIT 0,3;
SELECT * FROM sales LIMIT 1,3;
SELECT * FROM sales LIMIT 4,5;
SELECT * FROM sales ORDER BY `sale` DESC LIMIT 3,5;
SELECT * FROM sales WHERE `sale` <50000 ORDER BY `sale` DESC LIMIT 3;
SELECT * FROM sales WHERE `sale` > 50000 ORDER BY `year` DESC, `month`, `sale` DESC LIMIT 5;
#실습 5-7
SELECT SUM(`sale`) AS `합계` FROM `sales`;
SELECT AVG(`sale`) AS `평균` FROM `sales`; 
SELECT MAX(`sale`) AS `최댓값` FROM `sales`;
SELECT MIN(`sale`) AS `최솟값` FROM `sales`;
SELECT COUNT(*) AS `갯수` FROM `sales`;

SELECT SUBSTRING(`hp`,10,4) AS `전화번호 끝자리` FROM `Member`;

INSERT INTO `member` VALUES ('b101','을지문덕','010-5555-1234','사장',107,NOW());

SELECT * FROM `sales`;

SELECT MAX(`sale`) AS `2018년 1월 매출의 합` FROM `sales` WHERE `year` = 2018 AND `month` = 1;
SELECT MAX(`sale`) AS `5만원 이상 2019년 2월 매출`,
AVG(`sale`) AS `평균`
 FROM `sales` WHERE `year` = 2019 AND `month` = 2 AND `sale` >= 50000;

SELECT MIN(`sale`) AS `최저`,
MAX(`sale`) AS `최고`
FROM `sales` WHERE `year` IN(2020); 
#실습 5-8
SELECT * FROM `sales` GROUP BY `uid`;
SELECT * FROM `sales` GROUP BY `uid`,`year`;
SELECT * FROM `sales` GROUP BY `month`;
SELECT * FROM `sales` GROUP BY `sale`;
SELECT `uid`, COUNT(*) AS `건수` FROM `sales` GROUP BY `uid`;
SELECT `uid`, SUM(sale) AS `합계` FROM `sales` GROUP BY `uid`;
SELECT `uid`, AVG(sale) AS `평균` FROM `sales` GROUP BY `uid`;

SELECT `uid`,`year`,SUM(sale) AS `합계`
FROM `sales` GROUP BY `uid`,`year`;

SELECT `uid`,`year`,SUM(sale) AS `합계`
FROM `sales` GROUP BY `uid`,`year`
ORDER BY `year`, `합계` DESC;

SELECT `uid`,`year`, SUM(sale) AS `합계`
FROM `sales`
WHERE `sale` >= 50000 GROUP BY `uid`, `year`
ORDER BY `합계` DESC;
#실습 5-9
SELECT `uid`, SUM(sale) AS `합계` FROM `sales`
GROUP BY `uid`
HAVING `합계` >= 200000;

SELECT `uid`,`year`, SUM(sale) AS `합계`
FROM `sales` WHERE `sale` >= 100000
GROUP BY `uid`,`year`
HAVING `합계` >= 200000
ORDER BY `합계` DESC;
#실습 5-10
CREATE TABLE `Sales2` LIKE `Sales`;
INSERT INTO `Sales2` SELECT * FROM `Sales`;
UPDATE `Sales2` SET `year` = `year`+3;

SELECT * FROM `Sales` UNION SELECT * FROM `sales2`;
SELECT `uid`,`year`,`sale` FROM `sales`
UNION 
SELECT `uid`,`year`,`sale` FROM `sales2`;

SELECT `uid`,`year`,SUM(sale) AS `합계`
FROM `sales`
GROUP BY `uid`,`year`
UNION
SELECT `uid`, `year`, sum(sale) as `합계`
FROM `sales2`
GROUP BY `uid`, `year`
ORDER BY `year` ASC, `합계` DESC;

#실습 5-11
SELECT `seq`, `uid`, `sale` FROM `sales`
UNION
SELECT `seq`, `uid`, `sale` FROM `sales2`;

SELECT `seq`,`uid`, `sale` FROM sales
UNION ALL
SELECT `seq`,`uid`,`sale` FROM sales2;
#실습 5-12

SELECT * FROM `sales` INNER JOIN `member` ON sales.uid = member.uid;
SELECT sales.`seq`, sales.`year`, sales.`month`, sales.`uid`,`name`,`pos`,`sale` FROM sales
JOIN member ON sales.uid = member.uid;

SELECT * FROM `Sales` AS a
JOIN `Member` AS b
ON a.uid = b.uid;

SELECT a.seq, a.uid, sale, `name`, `pos` FROM `sales` AS a
JOIN `member` AS b
ON a.uid = b.uid;

SELECT a.`seq`, a.`uid`, `sale`, `name`,`pos`
FROM `sales` AS a, `member` AS b
WHERE a.uid = b.uid;

SELECT a.seq, a.uid, sale, `name`, `pos` FROM `sales` AS a
JOIN `member` AS b
USING(`uid`);

SELECT * FROM `sales` AS a
JOIN `member` 			 AS b ON a.uid = b.uid
JOIN `department`     AS c ON b.dep = c.depNo;
#실습 5-13


