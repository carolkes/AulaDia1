CREATE TABLE [dbo].[Funcionarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] NVARCHAR(50) NULL, 
    [DataInicio] DATETIME NULL, 
    [DataSaida] DATETIME NULL,
	[Ativo]            BIT           DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT           DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT           DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME      DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME      DEFAULT (getdate()) NULL,
)
