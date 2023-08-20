DECLARE @Ids TABLE(
    RowId UNIQUEIDENTIFIER
) 

INSERT INTO 
TestDB.dbo.AQLogTable
 ([ContentType] ,
    [Type] ,
    [Content] ,
    [ApplicationName] ,
    [CreateDate] ,
    [ChannelName] ,
    [Tag] ,
    [Author] ,
    [Header]
 )
OUTPUT INSERTED.RowID INTO @Ids

VALUES(
 'TEXT/PLAIN',
 'INFO',
 'Тестовый лог, для добавления в базу',
 'Docsvision',
  GETDATE(),
  '#TestChannel',
  'UpdateLog',
  'AzerQ',
  'Тест доксвижн'
)

SELECT * FROM TestDB.dbo.AQLogTable WHERE CreateDate >= GETDATE() - 1
FOR JSON AUTO