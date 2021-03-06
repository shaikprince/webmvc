USE [abc]
GO
/****** Object:  StoredProcedure [dbo].[EmployeeViewOrrInsert]    Script Date: 03-09-2021 11:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[EmployeeViewOrrInsert]
@mode NVARCHAR (MAX), @Id INT=NULL, @FirstName VARCHAR (50)=NULL, @LastName VARCHAR (50)=NULL, @DOB DATE=NULL, @Contact BIGINT=NULL, @RoleId INT=NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF (@mode = 'GetEmpList')
        BEGIN
            SELECT Id,
                   FirstName,
                   LastName,
                   DOB,
                   Contact,
                   RoleId
            FROM   employee;
        END
    IF (@mode = 'GetEmployeeList')
        BEGIN
            SELECT Id,
                   FirstName,
                   LastName,
                   DOB,
                   Contact,
                   RoleId
            FROM   employee;
        END
    IF (@mode = 'AddEmployee')
        BEGIN
            INSERT  INTO employee (FirstName, LastName, DOB, Contact, RoleId)
            VALUES               (@FirstName, @Lastname, @DOB, @Contact, @RoleId);
        END
    IF (@mode = 'GetEmployeeById')
        BEGIN
            SELECT Id,
                   FirstName,
                   LastName,
                   DOB,
                   Contact,
                   RoleId
            FROM   employee
            WHERE  Id = @Id;
        END
    IF (@mode = 'UpdateEmployee')
        BEGIN
            UPDATE employee
            SET    FirstName = @FirstName,
                   Lastname  = @LastName,
                   DOB       = @DOB,
                   Contact   = @Contact,
                   RoleId    = @RoleId
            WHERE  Id = @Id;
        END
    IF (@mode = 'DeleteEmployee')
        BEGIN
            DELETE employee
            WHERE  Id = @Id;
        END
END

