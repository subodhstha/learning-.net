

CREATE Procedure [dbo].[uspEmpAdd]
@FirstName Nvarchar(50),
@LastName Nvarchar(50)
As
INSERT INTO [dbo].[Employee]
(
	[FirstName],
	[LastName]
)
VALUES
(
	@FirstName,
	@LastName
)
GO

/****** Object:  StoredProcedure [dbo].[uspEmpDelete]    Script Date: 10/2/2022 12:48:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[uspEmpDelete]
@UserId int
As
Delete [dbo].[Employee] Where UserID = @UserID
GO

/****** Object:  StoredProcedure [dbo].[uspEmpGetAll]    Script Date: 10/2/2022 12:48:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[uspEmpGetAll]
As
Select * from [dbo].[Employee]
GO

/****** Object:  StoredProcedure [dbo].[uspEmpGetByUserID]    Script Date: 10/2/2022 12:48:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[uspEmpGetByUserID]
@UserId int
As
Select * from [dbo].[Employee] Where UserID = @UserID
GO

/****** Object:  StoredProcedure [dbo].[uspEmpUpdate]    Script Date: 10/2/2022 12:48:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[uspEmpUpdate]
@UserId int,
@FirstName Nvarchar(50),
@LastName Nvarchar(50)
As
Update [dbo].[Employee] Set
[FirstName] = @FirstName,
[LastName] = @LastName
Where
UserID = @UserId
GO


