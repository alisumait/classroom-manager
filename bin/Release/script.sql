USE [sas]
GO
/****** Object:  Table [dbo].[events]    Script Date: 12/25/2018 3:38:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[events](
	[bookerName] [varchar](50) NOT NULL,
	[slot_id] [varchar](50) NOT NULL,
	[eventType] [varchar](50) NOT NULL,
	[eventName] [varchar](50) NOT NULL,
	[attendees] [int] NOT NULL,
	[phoneNumber] [varchar](50) NOT NULL,
	[additionals] [text] NOT NULL,
 CONSTRAINT [PK_events] PRIMARY KEY CLUSTERED 
(
	[bookerName] ASC,
	[slot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[history]    Script Date: 12/25/2018 3:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[history](
	[bookerName] [varchar](50) NOT NULL,
	[slot_id] [varchar](50) NOT NULL,
	[eventType] [varchar](50) NOT NULL,
	[eventName] [varchar](50) NOT NULL,
	[attendees] [int] NOT NULL,
	[phoneNumber] [varchar](50) NOT NULL,
	[additionals] [text] NOT NULL,
 CONSTRAINT [PK_history] PRIMARY KEY CLUSTERED 
(
	[bookerName] ASC,
	[slot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[slots]    Script Date: 12/25/2018 3:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[slots](
	[slot_id] [varchar](50) NOT NULL,
	[block] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[startTime] [int] NOT NULL,
	[endTime] [int] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_slots] PRIMARY KEY CLUSTERED 
(
	[slot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/25/2018 3:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[pass] [nchar](10) NOT NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_users_1] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_users] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[events]  WITH CHECK ADD  CONSTRAINT [FK_events_slots] FOREIGN KEY([slot_id])
REFERENCES [dbo].[slots] ([slot_id])
GO
ALTER TABLE [dbo].[events] CHECK CONSTRAINT [FK_events_slots]
GO
