USE constraint_zadatak_2_2
CREATE TABLE radnici(
id INT IDENTITY (1,1) NOT NULL,
ime NCHAR (50) NOT NULL,
prezime NCHAR (50) NOT NULL,
CONSTRAINT chk_id CHECK ( id BETWEEN 1 AND 1000)
)
GO