# 3장 정렬과 연산
# order by로 검색 결과 정렬하기

CREATE DATABASE `Bookdb`;

CREATE TABLE `age`(
	`name` 		VARCHAR(10),
	`age` 		INT,
	`address`	VARCHAR(10)
);

INSERT INTO `age` VALUES('A','36','대구광역시 중구');
INSERT INTO `age` VALUES('B씨','18','부산광역시 연제구');
INSERT INTO `age` VALUES('C씨','25','서울특별시 중구');

SELECT * FROM `age`;
SELECT * FROM `age` ORDER BY age;

SELECT * FROM age ORDER BY address;

SELECT * FROM age ORDER BY age DESC;

CREATE TABLE `sample32`(
	`a` 	INT,
	`b`	int
);

INSERT INTO `sample32` VALUES('1','1');
INSERT INTO `sample32` VALUES('2','1');
INSERT INTO `sample32` VALUES('2','2');
INSERT INTO `sample32` VALUES('1','3');
INSERT INTO `sample32` VALUES('1','2');

SELECT * FROM `sample32`;

SELECT * FROM sample32 ORDER BY b DESC ,a;

# 결과 행 제한하기 Limit  -> 웹 브라우저의 페이지 나누기 기능에 사용된다.

CREATE TABLE `sample33`(
		`no` INT
);

INSERT INTO sample33 VALUES('1');
INSERT INTO sample33 VALUES('2');
INSERT INTO sample33 VALUES('3');
INSERT INTO sample33 VALUES('4');
INSERT INTO sample33 VALUES('5');
INSERT INTO sample33 VALUES('6');
INSERT INTO sample33 VALUES('7');

SELECT*FROM sample33 order by no DESC LIMIT 3;

SELECT*FROM sample33 LIMIT 3,3;
SELECT*FROM sample33 LIMIT 3 OFFSET 3;

# 12강 수치 연산
CREATE TABLE `sample34` (
		`no` 			INT 	PRIMARY KEY,
		`price`		INT,
		`quantity`	INT
);

INSERT INTO `sample34` VALUES('1','100','10');
INSERT INTO `sample34` VALUES('2','230','24');
INSERT INTO `sample34` VALUES('3','1980','1');

SELECT * FROM sample34;

SELECT*, price*quantity AS `amount` FROM sample34;
# as는 데이터에 존재하지 않은 별명이고 as의 처리가 where구 보다 늦기 때문에 사용할 수 없다.

# 서버에서의 내부처리 순서  where -> select(여기서 별명 작성) -> order by
SELECT*,price*quantity AS amount FROM sample34 
ORDER BY amount DESC;

CREATE TABLE `sample341`(
		`amount` 	FLOAT
);

INSERT INTO `sample341` VALUES('5961.60');
INSERT INTO `sample341` VALUES('2138.40');
INSERT INTO `sample341` VALUES('1080.00');

SELECT amount, ROUND(amount,-1) FROM sample341;

#13강 문자열 연산
