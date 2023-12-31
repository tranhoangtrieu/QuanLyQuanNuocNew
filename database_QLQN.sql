CREATE DATABASE [QuanLyQuanNuoc]
USE [QuanLyQuanNuoc]

GO
/****** Object:  UserDefinedFunction [dbo].[non_unicode_convert]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[non_unicode_convert](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[DisplayName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountInfo]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountInfo](
	[UserName] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[DateOfBirth] [date] NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PHONE] [nvarchar](11) NOT NULL,
	[Question] [nvarchar](50) NULL,
	[Answer] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PHONE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[TotalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 9/14/2023 7:04:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'erert', N'', N'', 0)
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'asd3', N'ad', N'12', 0)
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'QuanLy', N'admin', N'1', 1)
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'hà ', N'ha', N'1', 1)
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'tài', N'nv1', N'1', 0)
GO
INSERT [dbo].[AccountInfo] ([UserName], [Name], [Sex], [DateOfBirth], [Address], [PHONE], [Question], [Answer]) VALUES (N'admin', N'QuanLy', N'Nam', CAST(N'1990-05-15' AS Date), N'123 Main St, City', N'123421222', N'Bạn thích Quyển sa', N'ba')
INSERT [dbo].[AccountInfo] ([UserName], [Name], [Sex], [DateOfBirth], [Address], [PHONE], [Question], [Answer]) VALUES (N'nv1', N'tài', N'Nam', CAST(N'2002-02-20' AS Date), N'tàu', N'123456742', N'Bạn thích quyển sách nào ?', N'bạn')
INSERT [dbo].[AccountInfo] ([UserName], [Name], [Sex], [DateOfBirth], [Address], [PHONE], [Question], [Answer]) VALUES (N'ha', N'hà ', N'Nam', CAST(N'2023-09-05' AS Date), N'da', N'1239827368', N'Bạn thích quyển sách nào ?', N'nsj')
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (93, CAST(N'2023-07-19' AS Date), CAST(N'2023-07-19' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (94, CAST(N'2023-07-19' AS Date), CAST(N'2023-07-19' AS Date), 6, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (95, CAST(N'2023-07-20' AS Date), CAST(N'2023-07-20' AS Date), 6, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (96, CAST(N'2023-07-20' AS Date), CAST(N'2023-07-20' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (97, CAST(N'2023-07-20' AS Date), CAST(N'2023-07-20' AS Date), 6, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (98, CAST(N'2023-07-20' AS Date), CAST(N'2023-07-21' AS Date), 6, 1, 0, 10000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (99, CAST(N'2023-07-21' AS Date), CAST(N'2023-08-24' AS Date), 2, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (100, CAST(N'2023-07-21' AS Date), CAST(N'2023-07-21' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (101, CAST(N'2023-07-21' AS Date), CAST(N'2023-07-21' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (102, CAST(N'2023-08-24' AS Date), CAST(N'2023-08-24' AS Date), 3, 1, 0, 27000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (103, CAST(N'2023-08-24' AS Date), CAST(N'2023-08-24' AS Date), 11, 1, 4, 28800)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (104, CAST(N'2023-08-28' AS Date), CAST(N'2023-08-28' AS Date), 5, 1, 0, 13000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (105, CAST(N'2023-09-06' AS Date), CAST(N'2023-09-06' AS Date), 15, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (106, CAST(N'2023-09-07' AS Date), CAST(N'2023-09-07' AS Date), 2, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (107, CAST(N'2023-09-07' AS Date), CAST(N'2023-09-07' AS Date), 2, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (108, CAST(N'2023-09-08' AS Date), CAST(N'2023-09-08' AS Date), 15, 1, 20, 57600)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (109, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-10' AS Date), 4, 1, 0, 57000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (110, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-10' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (111, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-10' AS Date), 1, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (112, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-10' AS Date), 1, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (113, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-10' AS Date), 15, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (114, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-11' AS Date), 1, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (115, CAST(N'2023-09-11' AS Date), CAST(N'2023-09-11' AS Date), 1, 1, 0, 75000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (116, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (117, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 4, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (118, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (119, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 2, 1, 0, 20000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (120, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 15, 1, 0, 5000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (121, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 11, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (122, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 3, 1, 0, -30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (123, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-12' AS Date), 15, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (124, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 25000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (125, CAST(N'2023-09-12' AS Date), CAST(N'2023-09-13' AS Date), 4, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (126, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (127, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 47000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (128, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (129, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 15, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (130, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 4, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (131, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 4, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (132, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (133, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (134, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 15, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (137, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (139, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (141, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (143, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (145, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (146, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (148, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 4, 1, 0, 15000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [TotalPrice]) VALUES (150, CAST(N'2023-09-13' AS Date), CAST(N'2023-09-13' AS Date), 3, 1, 0, 15000)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (148, 98, 4, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (154, 102, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (156, 103, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (158, 104, 7, -1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (159, 104, 8, -1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (161, 104, 3, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (166, 108, 8, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (167, 108, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (169, 109, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (170, 109, 8, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (177, 115, 8, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (188, 119, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (189, 119, 4, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (190, 119, 5, -2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (191, 120, 4, -1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (195, 124, 4, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (200, 127, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (212, 133, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (213, 134, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (216, 137, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (218, 139, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (220, 141, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (222, 143, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (224, 145, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (225, 146, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (227, 148, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (229, 150, 1, 1)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Trà đào', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'coffee', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Trà sữa', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Cafe đen đá', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Bạc xỉu', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'7Up', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Bánh ngọt', 2, 12000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Bánh tráng', 2, 15000)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Nước')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Đồ ăn')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (1, N'Bàn 0', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (2, N'Bàn 1', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (3, N'Bàn 2', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (4, N'Bàn 3', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (5, N'Bàn 4', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (6, N'Bàn 5', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (7, N'Bàn 6', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (8, N'Bàn 7', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (9, N'Bàn 8', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (11, N'Bàn 10', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (15, N'Bàn 9', N'Trống')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[AccountInfo]  WITH CHECK ADD FOREIGN KEY([UserName])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
ALTER TABLE [dbo].[AccountInfo]  WITH CHECK ADD  CONSTRAINT [check_dt] CHECK  (([PHONE] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [PHONE] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [PHONE] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [PHONE] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [PHONE] IS NULL))
GO
ALTER TABLE [dbo].[AccountInfo] CHECK CONSTRAINT [check_dt]
GO
/****** Object:  StoredProcedure [dbo].[PR_GETTABLELIST]    Script Date: 9/14/2023 7:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_GETTABLELIST]
AS SELECT * FROM [dbo].[TableFood]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAccount]    Script Date: 9/14/2023 7:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteAccount]
	@UserName NVARCHAR(50)
	AS
	BEGIN
		
		delete  AccountInfo where UserName = @UserName
		delete  Account where UserName = @UserName

	END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertAccountWithInfo]    Script Date: 9/14/2023 7:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertAccountWithInfo]
    @DisplayName NVARCHAR(50),
    @UserName NVARCHAR(50),
    @PassWord NVARCHAR(50),
    @Type int,
    @Sex NVARCHAR(10),
    @DateOfBirth DATE,
    @Address NVARCHAR(100),
    @PHONE NVARCHAR(20),
    @Question NVARCHAR(100),
    @Answer NVARCHAR(100)
AS
BEGIN
    DECLARE @NewUserID INT

    -- Chèn dữ liệu vào bảng Account
    INSERT INTO Account (DisplayName, UserName, PassWord, Type)
    VALUES (@DisplayName, @UserName, @PassWord, @Type)

    -- Lấy ID của tài khoản mới được chèn
    SET @NewUserID = SCOPE_IDENTITY()

    -- Chèn dữ liệu vào bảng AccountInfo với ID mới
    INSERT INTO AccountInfo (UserName,Name,Sex ,DateOfBirth, Address, PHONE, Question, Answer)
    VALUES (@UserName,@DisplayName, @Sex,@DateOfBirth, @Address, @PHONE, @Question, @Answer)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteBill]    Script Date: 9/14/2023 7:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_deleteBill]
@id int
as
begin
	update Bill set status =1 where id =@id
	delete from BillInfo where idBill = @id
	delete from Bill where id = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillDate]    Script Date: 9/14/2023 7:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListBillDate]
	@checkIn date, @checkOut date
	as
	begin
	select  b.id, t.name,b.TotalPrice,DateCheckIn,DateCheckOut,discount
	from [dbo].[Bill] b ,[dbo].[TableFood] t
	where DateCheckIn >=@checkIn and DateCheckOut <= @checkOut and b.status =1 and t.id=b.idTable
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 9/14/2023 7:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
			  discount
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,
			  0-- status - int
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 9/14/2023 7:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO

