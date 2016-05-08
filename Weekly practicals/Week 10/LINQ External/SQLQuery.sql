IF OBJECT_ID('tblPicture') IS NOT NULL DROP TABLE tblPicture
IF OBJECT_ID('tblStrike') IS NOT NULL DROP TABLE tblStrike
IF OBJECT_ID('tblFire') IS NOT NULL DROP TABLE tblFire

CREATE TABLE tblStrike
(
		strikeID				int					IDENTITY,
		strikeDate				date				NOT NULL,
		strikeTime				time(0)				NOT NULL,
		strikeLatitude			numeric(5,2)		NOT NULL,
		strikeLongitude			numeric(5,2)		NOT NULL,
		strikeIntensity			int					NOT NULL,

		CONSTRAINT PK_tblStrike PRIMARY KEY (strikeID)
)

CREATE TABLE tblFire
(
		fireID					int					IDENTITY,
		fireDate				date				NOT NULL,
		fireLatitude			numeric(5,2)		NOT NULL,
		fireLongitude			numeric(5,2)		NOT NULL,
		fireArea				numeric(6,2)		NOT NULL,

		CONSTRAINT PK_tblFire PRIMARY KEY (fireID)
)

CREATE TABLE tblPicture
(
		pictureID				int					IDENTITY,
		strikeID				int					NOT NULL,	-- FK to tblStrike
		pictureDate				date				NOT NULL,
		pictureFileName			char(15)			NULL,

		CONSTRAINT PK_tblPicture PRIMARY KEY (pictureID),
		CONSTRAINT FK_STRIKE_PICTURE FOREIGN KEY (strikeID) REFERENCES tblStrike(strikeID)
)

--populate tblStrike
INSERT INTO tblStrike VALUES('20160405', '00:02:02', 41.34, -122.45, 6235)
INSERT INTO tblStrike VALUES('20160405', '00:02:02', 40.47, -120.47, 16235)
INSERT INTO tblStrike VALUES('20160405', '00:02:02', 42.14, -122.98, 7779)
INSERT INTO tblStrike VALUES('20160405', '00:02:02', 38.32, -122.17, 4645)
INSERT INTO tblStrike VALUES('20160405', '00:02:02', 39.04, -122.22, 8989)

--populate tblFire
INSERT INTO tblFire VALUES('20160405', 32.34, -122.45, 123.90)
INSERT INTO tblFire VALUES('20160405', 37.19, -121.66, 627.09)
INSERT INTO tblFire VALUES('20160405', 40.47, -120.47, 45.00)
INSERT INTO tblFire VALUES('20160405', 42.14, -122.98, 1774.9)
INSERT INTO tblFire VALUES('20160405', 37.21, -120.47, 2034.8)
INSERT INTO tblFire VALUES('20160405', 42.04, -126.22, 49.62)

--populate tblPicture
INSERT INTO tblPicture VALUES(1, '20160405', '04938245.png')
INSERT INTO tblPicture VALUES(1, '20160405', '04983284.png')
INSERT INTO tblPicture VALUES(2, '20160405', '04773626.png')
INSERT INTO tblPicture VALUES(2, '20160405', '04789789.png')
INSERT INTO tblPicture VALUES(4, '20160405', '04323456.png')
INSERT INTO tblPicture VALUES(5, '20160405', '04325342.png')