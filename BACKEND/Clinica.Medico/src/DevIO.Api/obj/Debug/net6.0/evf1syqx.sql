IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Especialidade] (
    [Id] nvarchar(450) NOT NULL,
    [Nome] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Especialidade] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Medico] (
    [Id] nvarchar(450) NOT NULL,
    [Nome] varchar(200) NOT NULL,
    [Crm] varchar(250) NOT NULL,
    [Idade] varchar(50) NOT NULL,
    [Telefone] varchar(200) NOT NULL,
    [Ddd] varchar(200) NOT NULL,
    CONSTRAINT [PK_Medico] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Consulta] (
    [Id] nvarchar(450) NOT NULL,
    [MedicoId] nvarchar(450) NOT NULL,
    [ClinicaId] nvarchar(max) NOT NULL,
    [PacienteId] nvarchar(max) NOT NULL,
    [Data] datetime2 NOT NULL,
    CONSTRAINT [PK_Consulta] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Consulta_Medico_MedicoId] FOREIGN KEY ([MedicoId]) REFERENCES [Medico] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [MedicoEspecialidade] (
    [MedicoId] nvarchar(450) NOT NULL,
    [EspecialidadeId] nvarchar(450) NOT NULL,
    [Id] nvarchar(max) NULL,
    CONSTRAINT [PK_MedicoEspecialidade] PRIMARY KEY ([EspecialidadeId], [MedicoId]),
    CONSTRAINT [FK_MedicoEspecialidade_Especialidade_EspecialidadeId] FOREIGN KEY ([EspecialidadeId]) REFERENCES [Especialidade] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MedicoEspecialidade_Medico_MedicoId] FOREIGN KEY ([MedicoId]) REFERENCES [Medico] ([Id]) ON DELETE NO ACTION
);
GO

CREATE UNIQUE INDEX [IX_Consulta_MedicoId] ON [Consulta] ([MedicoId]);
GO

CREATE INDEX [IX_MedicoEspecialidade_MedicoId] ON [MedicoEspecialidade] ([MedicoId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221108124531_Initial', N'6.0.9');
GO

COMMIT;
GO

