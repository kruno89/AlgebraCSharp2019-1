USE upisi;
CREATE TABLE upisi(
polaznici_id INT
	FOREIGN KEY 
		REFERENCES polaznici(id)
)