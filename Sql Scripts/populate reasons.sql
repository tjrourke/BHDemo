USE [BhhcDemo]
GO

declare @userName varchar(50) = 'Tim Rourke';

INSERT INTO [dbo].[Reasons]
           ([Title]
           ,[Text]
           ,[CreatedBy]
           ,[EditedBy])
     VALUES
           ('A New Application'
           ,'The challenge of contributing to a new application at the ground floor.'
           ,@userName
		   ,@userName),

		   
           ('Team building'
           ,'Participating in building a new team.'
           ,@userName
		   ,@userName),
		   
           ('Family and Friends'
           ,'Family and Friends will recognize the name of the company without too much explanation.'
           ,@userName
		   ,@userName)
GO


