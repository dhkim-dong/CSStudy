#날 짜 : 2022/07/18
#이 름 : 김 동 훈
#내 용 : SQL 기본 실습하기

#실 습1-1
CREATE DATABASE `UserDB`;
DROP DATABASE `UserDB`;
#실 습1-2
CREATE TABLE `User1` (
   `uid`    VARCHAR(10),
   `name`   VARCHAR(10),
   `hp`     CHAR(13),
   `age` 	INT
);

DROP TABLE `User1`;
#실 습1-3
INSERT INTO `User1` VALUES ('A101','김유신','010-1234-1111',25);
INSERT INTO `User1` VALUES ('A102','김춘추','010-1234-2222',23);
INSERT INTO `User1` VALUES ('A103','장보고','010-1234-3333',32);
INSERT INTO `User1` ('uid','name','age') 
				 VALUES ('A104','강감찬',45,);
INSERT INTO `User1` SET 
'uid'= 'A105', 
'name' = '이순신', 
'hp'='010-1234-5555';
#실 습1-4
#실 습1-5
#실 습1-6