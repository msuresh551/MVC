
--- Creating Employee Table
	
create table Employees
(ID int identity(1,1) primary key not null,EmpID int not null,Name varchar(20) not null, Gender varchar(20),Email varchar(50),DepartmentID int
,[Salary] [int] NULL
,[PersonnelWebSite] [nvarchar](100) NULL,
 [Dateofjoin] [datetime] NULL,
 [Age] [int] NOT NULL);

/****** Object:  Table [dbo].[Department]    Script Date: 3/11/2018 10:52:01 PM ******/
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Department] [varchar](150) NULL,
	[IsSelected] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[City]    Script Date: 3/11/2018 10:54:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[City](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NULL,
	[IsSelected] [bit] NULL
) ON [PRIMARY]

/****** Object:  Table [dbo].[Employees_test]    Script Date: 3/11/2018 10:55:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Employees_test](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NULL,
	[Gender] [varchar](150) NULL,
	[City] [varchar](150) NULL,
	[DepartmentID] [int] NULL,
	[Salary] [int] NULL,
	[PersonnelWebSite] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Dateofjoin] [datetime] NULL,
	[Age] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


-- Developing Simple Entity Frame work Class

CREATE TABLE [dbo].[Emps](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
