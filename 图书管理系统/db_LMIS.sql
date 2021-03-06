USE [master]
GO
/****** Object:  Database [db_LMIS]    Script Date: 2018/6/15 8:55:48 ******/
CREATE DATABASE [db_LMIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_LMIS', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_LMIS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_LMIS_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_LMIS_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_LMIS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_LMIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_LMIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_LMIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_LMIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_LMIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_LMIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_LMIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_LMIS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [db_LMIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_LMIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_LMIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_LMIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_LMIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_LMIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_LMIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_LMIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_LMIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_LMIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_LMIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_LMIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_LMIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_LMIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_LMIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_LMIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_LMIS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_LMIS] SET  MULTI_USER 
GO
ALTER DATABASE [db_LMIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_LMIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_LMIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_LMIS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [db_LMIS]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 2018/6/15 8:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[BID] [nchar](8) NOT NULL,
	[BName] [nvarchar](100) NULL,
	[BWriter] [nvarchar](50) NULL,
	[BPublish] [nvarchar](30) NULL,
	[BDate] [datetime] NULL,
	[BPrice] [float] NULL,
	[BNum] [int] NULL,
	[TID] [nvarchar](20) NULL,
	[BRemark] [varchar](200) NULL,
	[ISBN] [nchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BookOut]    Script Date: 2018/6/15 8:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookOut](
	[OID] [int] IDENTITY(1,1) NOT NULL,
	[BID] [nchar](8) NULL,
	[PID] [nchar](10) NULL,
	[ODate] [datetime] NULL,
	[isReturn] [bit] NULL,
	[isdelete] [bit] NULL,
	[ORemark] [nvarchar](200) NULL,
 CONSTRAINT [PK_bookOut] PRIMARY KEY CLUSTERED 
(
	[OID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Identity]    Script Date: 2018/6/15 8:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Identity](
	[identity] [nvarchar](50) NOT NULL,
	[longTime] [int] NULL,
	[bigNum] [tinyint] NULL,
 CONSTRAINT [PK_identity] PRIMARY KEY CLUSTERED 
(
	[identity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Manager]    Script Date: 2018/6/15 8:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[MName] [nvarchar](20) NOT NULL,
	[MCode] [nchar](32) NULL,
	[manage] [bit] NULL,
	[work] [bit] NULL,
	[query] [bit] NULL,
 CONSTRAINT [PK_manager] PRIMARY KEY CLUSTERED 
(
	[MName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 2018/6/15 8:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PID] [nchar](10) NOT NULL,
	[PName] [nvarchar](20) NULL,
	[PSex] [nchar](2) NULL,
	[PPhone] [nchar](11) NULL,
	[PN] [nchar](18) NULL,
	[PCode] [nvarchar](32) NULL,
	[PMoney] [float] NULL,
	[identity] [nchar](2) NULL,
	[PRemark] [nvarchar](200) NULL,
	[sys] [bit] NULL,
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seat]    Script Date: 2018/6/15 8:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seat](
	[S_NO] [nvarchar](15) NOT NULL,
	[S_Status] [tinyint] NULL,
	[S_Postion] [nvarchar](10) NULL,
	[S_remark] [nvarchar](100) NULL,
	[S_ID] [nchar](10) NULL,
 CONSTRAINT [PK_Seat] PRIMARY KEY CLUSTERED 
(
	[S_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Type]    Script Date: 2018/6/15 8:55:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Type](
	[TID] [int] IDENTITY(1,1) NOT NULL,
	[typename] [nvarchar](20) NOT NULL,
	[tRemark] [varchar](200) NULL,
 CONSTRAINT [PK_type] PRIMARY KEY CLUSTERED 
(
	[typename] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'1       ', N'C#程序编程', N'张三', N'人民出版社', CAST(0x00008C5D00000000 AS DateTime), 32, 5, N'1009', N'编程', N'BC           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'2       ', N'C语言程序设计', N'crq', N'台州学院出版社', CAST(0x0000999300000000 AS DateTime), 32, 3, N'1009', N'编程', N'BC           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'22      ', N'藏地密码', N'何马', N'重庆出版社', CAST(0x00009A7100000000 AS DateTime), 24.8, 3, N'1012', N'一部关于西藏的百科全书式小说', N'BK           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'3       ', N'山楂树之恋', N'艾米', N'江苏文艺出版社', CAST(0x00009B2800000000 AS DateTime), 25, 6, N'1011', N'精装', N'XS           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'32      ', N'张爱玲文集', N'张爱玲', N'重庆出版社', CAST(0x00009A7100000000 AS DateTime), 32, 2, N'1011', N'文集', N'WJ           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'4       ', N'虎出南亚', N'无住', N'新星出版社', CAST(0x00009B0A00000000 AS DateTime), 29.8, 8, N'1010', N'1942年1月，驻泰日军越过泰缅边境发动了侵缅战争。中国政府应英国政府请求，遂以第5、第6、第66军共十万余人组成中国远征军赴缅作战', N'JL           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'5       ', N'幸福的完美', N'石钟山', N'时代文艺出版社', CAST(0x00009B2800000000 AS DateTime), 18, 22, N'1011', N'散文', N'SW           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'6       ', N'舞者', N'海岩', N'人民文学出版社', CAST(0x00009B2800000000 AS DateTime), 35, 7, N'8', N'小说', N'XS           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'67      ', N'JAVA', N'李四', N'清华大学出版社', CAST(0x0000903000000000 AS DateTime), 66, 1, N'1009', N'编程', N'BC           ')
INSERT [dbo].[Book] ([BID], [BName], [BWriter], [BPublish], [BDate], [BPrice], [BNum], [TID], [BRemark], [ISBN]) VALUES (N'7       ', N'白夜行', N'（日）东野圭吾', N'南海出版社', CAST(0x00009B0A00000000 AS DateTime), 29.8, 6, N'小说', N'小说', N'XS           ')
SET IDENTITY_INSERT [dbo].[BookOut] ON 

INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1, N'1       ', N'1629210070', CAST(0x0000A8BA00000000 AS DateTime), 1, 0, N'已还')
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (2, N'67      ', N'1629210064', CAST(0x0000A8E900000000 AS DateTime), 1, 0, N'已还')
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (5, N'2       ', N'1629210070', CAST(0x0000A8FB00000000 AS DateTime), 0, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (6, N'67      ', N'1629210070', CAST(0x0000A8FB00000000 AS DateTime), 0, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (8, N'1       ', N'1629210070', CAST(0x0000A8FC00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (9, N'1       ', N'1629210070', CAST(0x0000A8FC00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (10, N'1       ', N'1629210070', CAST(0x0000A8FC00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (11, N'1       ', N'1629210070', CAST(0x0000A8FC00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (12, N'1       ', N'1629210070', CAST(0x0000A8FC00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1007, N'1       ', N'1629210070', CAST(0x0000A80700000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1008, N'1       ', N'1629210070', CAST(0x0000A7C200000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1009, N'1       ', N'1629210001', CAST(0x0000A8B500000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1010, N'1       ', N'1629210001', CAST(0x0000A8FE00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1011, N'1       ', N'1629210001', CAST(0x0000A8FE00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1012, N'1       ', N'1629210001', CAST(0x0000A8FE00000000 AS DateTime), 0, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1013, N'3       ', N'1629210001', CAST(0x0000A8FE00000000 AS DateTime), 0, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1014, N'1       ', N'1629210070', CAST(0x0000A8FF00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1015, N'1       ', N'1629210070', CAST(0x0000A8FF00000000 AS DateTime), 0, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1016, N'22      ', N'1629210070', CAST(0x0000A7EB00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1017, N'2       ', N'1629210001', CAST(0x0000A7FF00000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1018, N'32      ', N'1629210001', CAST(0x0000A89300000000 AS DateTime), 1, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1019, N'22      ', N'1629210001', CAST(0x0000A88500000000 AS DateTime), 0, 0, NULL)
INSERT [dbo].[BookOut] ([OID], [BID], [PID], [ODate], [isReturn], [isdelete], [ORemark]) VALUES (1020, N'32      ', N'1629210001', CAST(0x0000A8A100000000 AS DateTime), 1, 0, NULL)
SET IDENTITY_INSERT [dbo].[BookOut] OFF
INSERT [dbo].[Identity] ([identity], [longTime], [bigNum]) VALUES (N'老师', 20, 10)
INSERT [dbo].[Identity] ([identity], [longTime], [bigNum]) VALUES (N'学生', 10, 5)
INSERT [dbo].[Manager] ([MName], [MCode], [manage], [work], [query]) VALUES (N'1', N'1                               ', 1, 0, 0)
INSERT [dbo].[Manager] ([MName], [MCode], [manage], [work], [query]) VALUES (N'123', N'321                             ', 1, 1, 1)
INSERT [dbo].[Manager] ([MName], [MCode], [manage], [work], [query]) VALUES (N'2', N'2                               ', 0, 1, 0)
INSERT [dbo].[Manager] ([MName], [MCode], [manage], [work], [query]) VALUES (N'3', N'3                               ', 0, 0, 1)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210001', N'陶晓', N'女 ', N'673054     ', N'330724199803300909', N'123123                          ', 0, N'学生', N'1', NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210002', N'赵礼奕', N'女 ', N'672062     ', N'330724199803300909', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210003', N'张高超', N'男 ', N'663062     ', N'130800197007090796', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210004', N'赵艳', N'女 ', N'663062     ', N'330724199803300909', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210005', N'陶智善', N'女 ', N'534534     ', N'330724199803300909', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210006', N'丁涵阳', N'女 ', N'675062     ', N'220105197807130704', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210007', N'赵白茹', N'女 ', N'643523     ', N'330724199803300909', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210008', N'侯浦和', N'男 ', N'456456     ', N'370112198101077797', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210009', N'钱丹萱', N'女 ', N'345675     ', N'431003197007235446', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210010', N'彭鹏举', N'男 ', N'977535     ', N'420582199402077758', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210011', N'钱平春', N'男 ', N'456764     ', N'653022199106219741', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210012', N'周水凡', N'女 ', N'566533     ', N'532529200003101969', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210013', N'陶雨山', N'男 ', N'435346     ', N'330724199803300909', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210014', N'卢以冬', N'女 ', N'653553     ', N'533122199505018582', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210015', N'于采珊', N'女 ', N'223456     ', N'32060019831030192X', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210016', N'严元彤', N'女 ', N'435674     ', N'650205199512123464', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210017', N'陶玄楚', N'男 ', N'234456     ', N'532529200003101969', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210018', N'顾伟诚 ', N'男 ', N'897678     ', N'61011220001225355X', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210019', N'袁新霁 ', N'男 ', N'678988     ', N'632321197305313091', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210024', N'陆哲茂 ', N'男 ', N'345467     ', N'210800197109274676', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210025', N'江安然 ', N'男 ', N'786345     ', N'511526197507226695', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210026', N'陶思羽', N'男 ', N'356875     ', N'210800197109274676', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210027', N'邱康宁', N'男 ', N'628586     ', N'500240197611299577', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210039', N'孔俊德 ', N'男 ', N'907234     ', N'510304199704206596', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210040', N'杨乐游 ', N'男 ', N'385023     ', N'142330197507303094', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210041', N'陶令法', N'男 ', N'638586     ', N'500240197611299577', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210042', N'徐雨伯 ', N'男 ', N'345876     ', N'130924198710146473', N'123123', 0, N'老师', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210047', N'陶百瑞', N'男 ', N'625586     ', N'142330197507303094', N'123123', 0, N'学生', NULL, NULL)
INSERT [dbo].[Person] ([PID], [PName], [PSex], [PPhone], [PN], [PCode], [PMoney], [identity], [PRemark], [sys]) VALUES (N'1629210064', N'史四', N'男 ', N'663059     ', N'330724199806217374', N'123123', 0, N'老师', NULL, 1)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-001', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-002', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-003', 1, N'101', N'一等座', N'1629210070')
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-004', 1, N'101', N'一等座', N'1629210001')
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-005', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-006', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-007', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-008', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-009', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-010', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-011', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-012', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-013', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-014', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-015', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-016', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-017', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-018', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-019', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-020', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-021', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-022', 0, N'101', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-023', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-024', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-025', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-026', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-027', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-028', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-029', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-101-030', 0, N'101', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-001', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-002', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-003', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-004', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-005', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-006', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-007', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-008', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-009', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-010', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-011', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-012', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-013', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-014', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-015', 0, N'102', N'一等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-016', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-017', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-018', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-019', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-020', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-021', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-022', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-023', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-024', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-025', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-026', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-027', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-028', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-029', 0, N'102', N'二等座', NULL)
INSERT [dbo].[Seat] ([S_NO], [S_Status], [S_Postion], [S_remark], [S_ID]) VALUES (N'zw-102-030', 0, N'102', N'二等座', NULL)
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (1012, N'BK', N'百科')
INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (4, N'DS', N'都市')
INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (1010, N'JL', N'记录')
INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (1009, N'JS', N'技术')
INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (1, N'KH', N'科幻')
INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (1011, N'SW', N'散文')
INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (3, N'XH', N'玄幻')
INSERT [dbo].[Type] ([TID], [typename], [tRemark]) VALUES (8, N'YQ', N'言情')
SET IDENTITY_INSERT [dbo].[Type] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书编号（主键）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BWriter'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版社' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BPublish'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'价格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'TID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book', @level2type=N'COLUMN',@level2name=N'BRemark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Book'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借出图书ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut', @level2type=N'COLUMN',@level2name=N'OID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut', @level2type=N'COLUMN',@level2name=N'BID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书证编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut', @level2type=N'COLUMN',@level2name=N'PID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借出日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut', @level2type=N'COLUMN',@level2name=N'ODate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否还书' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut', @level2type=N'COLUMN',@level2name=N'isReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut', @level2type=N'COLUMN',@level2name=N'isdelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut', @level2type=N'COLUMN',@level2name=N'ORemark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借出图书信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookOut'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份（主键）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Identity', @level2type=N'COLUMN',@level2name=N'identity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最长借阅时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Identity', @level2type=N'COLUMN',@level2name=N'longTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最大借阅数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Identity', @level2type=N'COLUMN',@level2name=N'bigNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Identity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称（主键）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'MName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'MCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'manage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'work'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'查询' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'query'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书证编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PSex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PPhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'罚款' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PMoney'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'identity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'PRemark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person', @level2type=N'COLUMN',@level2name=N'sys'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借阅者信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Person'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'座位编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Seat', @level2type=N'COLUMN',@level2name=N'S_NO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'座位状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Seat', @level2type=N'COLUMN',@level2name=N'S_Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类别ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Type', @level2type=N'COLUMN',@level2name=N'TID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类别（主键）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Type', @level2type=N'COLUMN',@level2name=N'typename'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类别描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Type', @level2type=N'COLUMN',@level2name=N'tRemark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书类别信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Type'
GO
USE [master]
GO
ALTER DATABASE [db_LMIS] SET  READ_WRITE 
GO
