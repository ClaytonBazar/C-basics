CREATE TABLE [dbo].[Funcionario] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [codigo]          INT          NOT NULL,
    [nome]            VARCHAR (50) NOT NULL,
    [diasTrabalhados] INT         NOT NULL,
    [salarioDiario]   BIGINT       NOT NULL,
    [salarioMensal]   BIGINT       NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([codigo] ASC)
);

