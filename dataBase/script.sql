USE [znak_db]
GO
/****** Object:  Table [dbo].[zodiacSign]    Script Date: 21.11.2023 21:48:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zodiacSign](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[surname] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[sign] [nchar](10) NULL,
	[birthdate] [date] NULL,
 CONSTRAINT [PK_zodiacSign] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[zodiacSign] ON 

INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (1, N'Немтырёва', N'Ксения', N'Близнецы  ', CAST(N'2004-05-29' AS Date))
INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (2, N'Немтырёв', N'Константин', N'Дева      ', CAST(N'2013-09-10' AS Date))
INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (3, N'Немтырёва', N'Кристина', N'Близнецы  ', CAST(N'2016-05-31' AS Date))
INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (5, N'Птицына', N'Екатерина', N'Телец     ', CAST(N'2003-04-29' AS Date))
INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (6, N'Бросалин', N'Вячеслав', N'Близнецы  ', CAST(N'1992-05-28' AS Date))
INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (7, N'Бросалина', N'Юлия', N'Близнецы  ', CAST(N'2000-06-20' AS Date))
INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (9, N'Немтырёва', N'Анна', N'Весы      ', CAST(N'1986-10-21' AS Date))
INSERT [dbo].[zodiacSign] ([id], [surname], [name], [sign], [birthdate]) VALUES (10, N'Губанова', N'Алёна', N'Близнецы  ', CAST(N'2004-06-17' AS Date))
SET IDENTITY_INSERT [dbo].[zodiacSign] OFF
GO
