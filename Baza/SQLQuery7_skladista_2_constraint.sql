USE skladista
ALTER TABLE skladisna_mjesta
ADD
-- mjesto nvarchar(50)
CONSTRAINT ck_provjera CHECK
(mjesto IN('Zagreb', 'Rijeka', 'Sisak'))
GO