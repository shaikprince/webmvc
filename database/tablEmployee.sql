/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[FirstName]
      ,[LastName]
      ,[DOB]
      ,[Contact]
      ,[RoleId]
  FROM [abc].[dbo].[employee]