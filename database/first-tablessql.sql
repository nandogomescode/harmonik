CREATE TABLE Scales (
    ScaleId INT PRIMARY KEY IDENTITY,
    ScaleName NVARCHAR(50) NOT NULL,
    IdNote INT NOT NULL, --Tonalidade Ex: C, D# F
    ScaleType NVARCHAR(20) NOT NULL,-- Major, minor, natura, harmonic, etc
    FOREIGN KEY (IdNote) REFERENCES Notes(NoteId)
);

CREATE TABLE Chords (

	ChordId INT PRIMARY KEY IDENTITY
	, ChordName NVARCHAR(50) NOT NULL
	, Degree NVARCHAR(5) NOT NULL -- i, ii, iii, iv...
	, IdScale INT NOT NULL

	FOREIGN KEY (IdScale) REFERENCES Scales(ScaleId)

);

CREATE TABLE Notes (

	NoteId INT PRIMARY KEY IDENTITY
	, NoteName NVARCHAR(10) NOT NULL
	, NoteKey NVARCHAR(10) NOT NULL 

);

INSERT INTO Notes VALUES (

	'Sí',
	'B'

);

SELECT * FROM Notes;
