#7장 복수의 테이블 다루기
#31강 집합연산 Union
CREATE TABLE `sample71_a`(
	`a` 	INT PRIMARY KEY
);
CREATE TABLE `sample71_b`(
	`a` INT PRIMARY KEY 
);

INSERT INTO sample71_a VALUES(1);
INSERT INTO sample71_a VALUES(2);
INSERT INTO sample71_a VALUES(3);

INSERT INTO sample71_b VALUES(2);
INSERT INTO sample71_b VALUES(10);
INSERT INTO sample71_b VALUES(11);

SELECT*FROM sample71_a
UNION
SELECT*FROM sample71_b;

#32강 테이블 결합 join
CREATE TABLE `재고수`(
	`상품코드` 		CHAR(4) PRIMARY KEY,
	`입고날짜`		DATE,
	`재고수`			 INT
);

INSERT INTO `재고수` VALUES('0001','2014-01-03',200);
INSERT INTO `재고수` VALUES('0002','2014-02-10',500);
INSERT INTO `재고수` VALUES('0003','2014-02-15',10);

CREATE TABLE `상품`(
	`상품코드`		CHAR(4) 	PRIMARY KEY,
	`상품명`			 VARCHAR(10),
	`메이커명`		VARCHAR(10),
	`가격`		     INT,
	`상품분류`		VARCHAR(10)
);

INSERT INTO `상품` VALUES('0001','상품oo','oo메이커',100,'식료품');
INSERT INTO `상품` VALUES('0002','상품xo','xo메이커',200,'식료품');
INSERT INTO `상품` VALUES('0003','상품ss','ss메이커',1980,'생활용품');

SELECT*FROM 상품,재고수
WHERE 상품.상품코드 = 재고수.상품코드 AND 상품.상품분류 = '식료품';

SELECT 상품.상품명,재고수.재고수 
FROM 상품 INNER JOIN 재고수
ON 상품.상품코드 = 재고수.상품코드
WHERE 상품.상품분류 = '식료품';

