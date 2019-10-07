CREATE TABLE [dbo].[Salarios]
(
	[Id] INT IDENTITY(1,1)  NOT NULL , 
    [FuncionarioId] INT NOT NULL, 
    [Valor] MONEY NOT NULL,
	[Ativo]            BIT           DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT           DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT           DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME      DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME      DEFAULT (getdate()) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Pedidos_To_Funcionarios] FOREIGN KEY ([FuncionarioId]) REFERENCES [dbo].[Funcionarios] ([Id])
)
