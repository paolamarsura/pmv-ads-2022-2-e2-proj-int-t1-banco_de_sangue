USE [banco_sangue]
GO
/****** Object:  Table [dbo].[cidade]    Script Date: 02/10/2022 17:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cidade](
	[id] [int] NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[estado] [varchar](2) NOT NULL,
 CONSTRAINT [PK_cidade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formulario]    Script Date: 02/10/2022 17:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formulario](
	[id] [int] NOT NULL,
	[data_nascimento] [date] NOT NULL,
	[peso] [float] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[resfriado] [bit] NOT NULL,
	[gravidez] [bit] NOT NULL,
	[amamentando] [bit] NOT NULL,
	[tatuagem] [bit] NOT NULL,
	[maquiagem_definitiva] [bit] NOT NULL,
	[micro_pigmentacao] [bit] NOT NULL,
	[relacao_sexual_risco] [bit] NOT NULL,
	[extracao_dente] [bit] NOT NULL,
	[cirurgia_anestesia] [bit] NOT NULL,
	[acupuntura] [bit] NOT NULL,
	[vacina_gripe] [bit] NOT NULL,
	[herpes] [bit] NOT NULL,
	[malaria] [bit] NOT NULL,
	[febre_amarela] [bit] NOT NULL,
	[corona_virus] [bit] NOT NULL,
	[parkinson] [bit] NOT NULL,
	[aids] [bit] NOT NULL,
	[hepatite] [bit] NOT NULL,
	[ultima_doacao] [date] NOT NULL,
 CONSTRAINT [PK_formulario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[instituicao]    Script Date: 02/10/2022 17:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[instituicao](
	[id] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[end_cidade_id] [int] NOT NULL,
	[end_numero] [varchar](100) NOT NULL,
	[end_bairro] [varchar](50) NOT NULL,
	[end_complemento] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 02/10/2022 17:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[cpf] [int] NULL,
	[tipo_sangue] [varchar](3) NULL,
	[end_cidade_id] [int] NULL,
	[end_numero] [varchar](100) NULL,
	[end_bairro] [varchar](100) NULL,
	[end_complemento] [varchar](100) NULL,
	[doador] [bit] NOT NULL,
	[adm] [bit] NOT NULL,
	[senha] [text] NOT NULL,
	[sexo] [varchar](50) NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[formulario]  WITH CHECK ADD  CONSTRAINT [FK_formulario_usuario] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_usuario]
GO
ALTER TABLE [dbo].[instituicao]  WITH CHECK ADD  CONSTRAINT [FK_instituicao_cidade] FOREIGN KEY([end_cidade_id])
REFERENCES [dbo].[cidade] ([id])
GO
ALTER TABLE [dbo].[instituicao] CHECK CONSTRAINT [FK_instituicao_cidade]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_cidade1] FOREIGN KEY([end_cidade_id])
REFERENCES [dbo].[cidade] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_cidade1]
GO
