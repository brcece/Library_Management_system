USE [Library]
GO
/****** Object:  Table [dbo].[BooksList]    Script Date: 25.12.2022 20:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BooksList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[book_name] [varchar](150) NOT NULL,
	[author] [varchar](150) NOT NULL,
	[type] [nvarchar](50) NULL,
	[number_of_pages] [varchar](150) NOT NULL,
	[time] [varchar](150) NOT NULL,
	[stock] [int] NULL,
 CONSTRAINT [PK__BooksLis__3213E83F0FC0E734] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow__history]    Script Date: 25.12.2022 20:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow__history](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[booknameid] [int] NOT NULL,
	[bookname] [varchar](150) NOT NULL,
	[userid] [int] NOT NULL,
	[studentname] [varchar](150) NOT NULL,
	[studentID] [int] NOT NULL,
	[startedtime] [varchar](150) NOT NULL,
	[endingtime] [varchar](150) NOT NULL,
	[isitreturn] [bit] NOT NULL,
 CONSTRAINT [PK__Borrow____3213E83F81A6A7FC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow_List]    Script Date: 25.12.2022 20:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow_List](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[booknameid] [int] NOT NULL,
	[bookname] [varchar](150) NOT NULL,
	[userid] [int] NOT NULL,
	[studentname] [varchar](150) NULL,
	[studentID] [int] NULL,
	[startedtime] [varchar](150) NOT NULL,
	[endingtime] [varchar](150) NOT NULL,
 CONSTRAINT [PK__Borrow_L__3213E83FC0A6A66A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Read_List]    Script Date: 25.12.2022 20:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Read_List](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NULL,
	[bookid] [int] NOT NULL,
	[Book_Name] [varchar](150) NOT NULL,
	[Author] [varchar](150) NOT NULL,
	[Book_Type] [varchar](150) NOT NULL,
	[Number_of_Pages] [int] NOT NULL,
	[Timee] [varchar](150) NOT NULL,
	[Read_or_Not_Read] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roleName]    Script Date: 25.12.2022 20:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roleName](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userTable]    Script Date: 25.12.2022 20:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](150) NOT NULL,
	[username] [varchar](150) NOT NULL,
	[birthday] [varchar](150) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[pass] [varchar](150) NOT NULL,
	[studentID] [int] NULL,
	[roleid] [int] NULL,
 CONSTRAINT [PK__userTabl__3213E83F0169D4FE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
