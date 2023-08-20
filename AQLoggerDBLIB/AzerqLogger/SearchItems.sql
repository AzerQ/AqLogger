
 IF EXISTS (
  SELECT *
      FROM INFORMATION_SCHEMA.ROUTINES
  WHERE SPECIFIC_SCHEMA = N'dbo'
      AND SPECIFIC_NAME = N'SearchLogItems'
      AND ROUTINE_TYPE = N'PROCEDURE'
  )
  DROP PROCEDURE dbo.SearchLogItems
  GO

  CREATE PROCEDURE dbo.SearchLogItems
    @ContentType VARCHAR(50) = '',
    @Type VARCHAR(50) = '',
    @Content NVARCHAR(MAX) = '',
    @StartDate DATETIME = "01/01/01",
    @EndDate DATETIME = "01/01/2099",
    @ChannelName VARCHAR(100) = '',
    @Tag VARCHAR(80) = '',
    @Author VARCHAR (100) = '',
    @Header NVARCHAR (150) = ''
  AS
  BEGIN

     SELECT * FROM TestDB.dbo.AQLogTable Logs WHERE
     Logs.ContentType like @ContentType + '%'
     AND Logs.[Type] like @Type + '%'
     AND Logs.Content like '%'+@Content+'%'
     AND Logs.ChannelName like @ChannelName + '%'
     AND Logs.Tag like @Tag + '%'
     AND Logs.Author like @Author + '%'
     AND Logs.Header like '%' + @Header + '%'
     AND ( (Logs.CreateDate >= @StartDate) AND (Logs.CreateDate <= @EndDate) )

  END
  GO


