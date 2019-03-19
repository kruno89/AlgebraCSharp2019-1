-- linijski komentar
/* blok komentar
CREATE DATABASE upisi
GO
*/
USE upisi;
create table #privremena(
id int, 
ime nchar(50),
prezime varchar(50),
mjesto_stanovanja nchar(25)
);
INSERT INTO [dbo].[#privremena] (
[id], [ime], [prezime], [mjesto_stanovanja]) 
VALUES (0, N'Pero                                              ', 
N'Peric',
N'Osijek                   ');
select * from #privremena;