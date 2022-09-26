CREATE PROCEDURE [dbo].[Usp_Sel_Read]
AS
BEGIN

	SELECT P.Id, P.Name, P.Lastname, D.Shortname, P.DocumentNumber 
	FROM dbo.Person AS P 
	JOIN dbo.DocumentType AS D
	ON P.DocumentTypeId = D.Id

END