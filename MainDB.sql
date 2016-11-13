BEGIN TRANSACTION;
CREATE TABLE "Words" (
	`ID`	INTEGER,
	`Word`	TEXT NOT NULL UNIQUE,
	`Alphabet`	TEXT NOT NULL,
	`Lists`	TEXT NOT NULL DEFAULT 1,
	PRIMARY KEY(ID)
);
INSERT INTO `Words` VALUES (1,'esoteric','e','1');
INSERT INTO `Words` VALUES (2,'recondite','r','1');
INSERT INTO `Words` VALUES (3,'obscure','o','1');
INSERT INTO `Words` VALUES (4,'common','c','1');
INSERT INTO `Words` VALUES (5,'familiar','f','1');
INSERT INTO `Words` VALUES (6,'ordinary','o','1');
INSERT INTO `Words` VALUES (7,'rare','r','1');
CREATE TABLE `WordList` (
	`ID`	INTEGER,
	`ListName`	TEXT NOT NULL UNIQUE,
	PRIMARY KEY(ID)
);
CREATE TABLE [Synonyms] (
    [ID] integer PRIMARY KEY NOT NULL,
    [Synonym] integer,
    [Meaning_ID] integer,
    CONSTRAINT [FK_Synonyms_0_0] FOREIGN KEY ([Meaning_ID]) REFERENCES [Meanings] ([ID]) MATCH NONE ON UPDATE NO ACTION ON DELETE NO ACTION
);
CREATE TABLE "PoS" (
	`ID`	Integer,
	`PoS`	text NOT NULL,
	PRIMARY KEY(ID)
);
INSERT INTO `PoS` VALUES (1,'noun');
INSERT INTO `PoS` VALUES (2,'verb t.');
INSERT INTO `PoS` VALUES (3,'verb int.');
INSERT INTO `PoS` VALUES (4,'adjective');
INSERT INTO `PoS` VALUES (5,'adverb');
INSERT INTO `PoS` VALUES (6,'interjection');
INSERT INTO `PoS` VALUES (7,'preposition');
INSERT INTO `PoS` VALUES (8,'conjunction');
INSERT INTO `PoS` VALUES (9,'pronoun');
CREATE TABLE Meanings (ID Integer, Word_ID Integer Not Null, PoS_ID Integer Not Null, Meaning Text Not Null, Usage Text, Primary Key (ID), FOREIGN KEY(`Word_ID`) REFERENCES Words(ID), FOREIGN KEY(`PoS_ID`) REFERENCES PoS(ID));
CREATE TABLE "Antonyms" (
	`ID`	INTEGER,
	`Antonym`	INTEGER NOT NULL,
	`Meaning_ID`	INTEGER NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(`Meaning_ID`) REFERENCES Meanings ( ID )
);
COMMIT;
