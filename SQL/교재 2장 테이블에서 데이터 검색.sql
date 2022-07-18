#날짜 : 2022/07/18
#이름 : 김동훈
#내용 : 교재 2장 테이블에서 데이터 검색

CREATE TABLE `sample21`(
	`no`			INT,        
	`name`		VARCHAR(10),
	`birthday`  CHAR(10),
	`address`	VARCHAR(100)
);

#데이터 저장 
INSERT INTO `sample21` Values (1,'박준용','1976-10-18','');
INSERT INTO `sample21`(`no`,`name`) VALUES (2,'김재진');
INSERT INTO `sample21`(`no`,`name`) VALUES (3,'홍길동');

#53

SELECT * FROM `sample21`;

#62

DESC sample21;

#6강 검색 조건 지정하기

#66
SELECT `no`,`name` FROM  `sample21`;

#68
SELECT *FROM `sample21` WHERE `no`=2;

#70
SELECT * FROM `sample21` WHERE `no`<>2;

#71
SELECT * FROM `sample21` WHERE `name`= '박준용';

#72~73
SELECT * FROM `sample21` WHERE `birthday`NULL;

#7강 조건 조합하기

#테이블 생성
CREATE TABLE `sample24`(
		`no`      INT,
		`a` 		 INT,
		`b`		 INT,
		`c`		 INT
);

INSERT INTO `sample24` VALUES (1,1,0,0);
INSERT INTO `sample24` VALUES (2,0,1,0);
INSERT INTO `sample24` VALUES (3,0,0,1);
INSERT INTO `sample24` VALUES (4,2,2,0);
INSERT INTO `sample24` VALUES (5,0,2,2);

#76
SELECT * FROM `sample24`;
#77
SELECT * FROM `sample24` WHERE a <>0 AND b <>0;

#78 A열이 0이 아니거나 b열이 0이 아닌 행
SELECT * FROM `sample24` WHERE a <>0 OR b <>0;

#80 or 연산자와 and 연산자의 우선 순위 and가 우선처리된다. 따라서 ( ) 기호를 사용하는 것이 좋다.
SELECT * FROM `sample24` WHERE a =1 OR a=2 AND b=1 OR b=2;

#82 not 연산자
SELECT*FROM `sample24` WHERE NOT(a<>0 OR b<>0);

# 8강 패턴 매칭에 의한 검색
CREATE TABLE `sample25`(
		`no`			INT,
		`text`		VARCHAR(255)
);

INSERT INTO `sample25` VALUES(1,'SQL은 RDBMS를 조작하는 언어이다');
INSERT INTO `sample25` VALUES(2,'LIKE에서는 메타문자%와 _를 사용할 수 있다');
INSERT INTO `sample25` VALUES(3,'LIKE는 SQL에서 사용할 수 있는 술어 중 하나이다');
INSERT INTO `sample25` VALUES(4,'it''s');

DELETE FROM `sample25` WHERE `no`=4;
UPDATE `sample25` SET `text` = '''' WHERE `no`=4;
#85 LIKE는 술어 'sql%'로 패턴 매칭 : 문자열 시작이 sql인 것을 찾아라 전방 일치
SELECT * FROM `sample25`;
SELECT*FROM `sample25` WHERE `text` LIKE'SQL%';

#86 중간일치
SELECT*FROM `sample25` WHERE `text` LIKE '%SQL%';

#88 LIKE 이스케이프 : %와 _를 찾기 위해서 사용하는 \
SELECT*FROM `sample25` WHERE `text` LIKE '%\_%';