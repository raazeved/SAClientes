USE [WSDL1]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 31/12/2019 08:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[CliID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[DataNasc] [smalldatetime] NULL,
	[CNPJ_CPF] [varchar](20) NOT NULL,
	[DOC] [varchar](20) NOT NULL,
	[CEP] [varchar](9) NOT NULL,
	[EndPri] [varchar](100) NULL,
	[NumPri] [int] NULL,
	[ComplPri] [varchar](30) NULL,
	[BaiPri] [varchar](40) NULL,
	[CidPri] [varchar](40) NULL,
	[UF] [varchar](2) NULL,
	[TelPri] [varchar](18) NULL,
	[Whatsapp] [varchar](18) NULL,
	[email] [varchar](60) NULL,
	[status] [varchar](1) NULL
) ON [PRIMARY]
GO
