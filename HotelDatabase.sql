USE [HotelManagement]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/15/2020 2:23:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Adminid] [int] NOT NULL,
	[AdminName] [varchar](50) NOT NULL,
	[AdminEmail] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Adminid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 5/15/2020 2:23:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[RoomNo] [int] NOT NULL,
	[CName] [varchar](50) NOT NULL,
	[NumberofPersons] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Numberofdays] [int] NOT NULL,
	[Checkin] [datetime] NOT NULL,
	[Checkout] [datetime] NOT NULL,
	[Roomtype] [varchar](50) NOT NULL,
	[NumberofRooms] [int] NOT NULL,
	[TotalAmount] [money] NOT NULL,
	[Phone] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomsDetails]    Script Date: 5/15/2020 2:23:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomsDetails](
	[RoomNo] [int] NOT NULL,
	[NumberofRooms] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Roomtype] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Signup]    Script Date: 5/15/2020 2:23:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Signup](
	[Phone] [bigint] NOT NULL,
	[CName] [varchar](50) NOT NULL,
	[Userid] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[AadharNo] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD FOREIGN KEY([Phone])
REFERENCES [dbo].[Signup] ([Phone])
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD FOREIGN KEY([RoomNo])
REFERENCES [dbo].[RoomsDetails] ([RoomNo])
GO
ALTER TABLE [dbo].[RoomsDetails]  WITH CHECK ADD CHECK  (([Roomtype]='Normal' OR [Roomtype]='Deluxe'))
GO
