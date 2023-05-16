--USE Demo

SELECT @@VERSION
SELECT GETDATE()
SELECT SYSDATETIME()

SELECT * 
FROM dbo.Movie
WHERE 
	MovieId = 1
	AND [Name] = 'Movie 1'

SELECT * 
FROM dbo.Movie

INSERT dbo.Movie
([Name], ImageUrl)
VALUES ('Pelicula 1', NULL)
GO 10



INSERT dbo.Movie
(MovieId, [Name])
VALUES (2, 'Movie 2')


--DELETE dbo.Movie



--UPDATE 