﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
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

CREATE TABLE [Convenio] (
    [Id] varchar(100) NOT NULL,
    [Nome] varchar(200) NOT NULL,
    [NCarteira] varchar(50) NOT NULL,
    [Vencimento] varchar(250) NOT NULL,
    CONSTRAINT [PK_Convenio] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Especialidade] (
    [Id] varchar(100) NOT NULL,
    [Nome] varchar(100) NOT NULL,
    CONSTRAINT [PK_Especialidade] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Medico] (
    [Id] varchar(100) NOT NULL,
    [Nome] varchar(200) NOT NULL,
    [Crm] varchar(250) NOT NULL,
    [Idade] varchar(50) NOT NULL,
    CONSTRAINT [PK_Medico] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Paciente] (
    [Id] varchar(100) NOT NULL,
    [Name] varchar(100) NOT NULL,
    [Idade] varchar(100) NOT NULL,
    [Rg] varchar(100) NOT NULL,
    [Cpf] varchar(100) NOT NULL,
    CONSTRAINT [PK_Paciente] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Telefone] (
    [Id] varchar(100) NOT NULL,
    [ddd] varchar(100) NOT NULL,
    [numero] varchar(100) NOT NULL,
    CONSTRAINT [PK_Telefone] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PacienteConvenio] (
    [Id] varchar(100) NOT NULL,
    [ConvenioId] varchar(100) NULL,
    CONSTRAINT [PK_PacienteConvenio] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PacienteConvenio_Convenio_ConvenioId] FOREIGN KEY ([ConvenioId]) REFERENCES [Convenio] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [TipoPagamento] (
    [Id] varchar(100) NOT NULL,
    [Pagamentos] int NOT NULL,
    [ConveniosId] varchar(100) NULL,
    CONSTRAINT [PK_TipoPagamento] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TipoPagamento_Convenio_ConveniosId] FOREIGN KEY ([ConveniosId]) REFERENCES [Convenio] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Endereco] (
    [Id] varchar(100) NOT NULL,
    [Numero] int NOT NULL,
    [Bairro] varchar(100) NOT NULL,
    [Cidade] varchar(100) NOT NULL,
    [Estado] varchar(100) NOT NULL,
    [Pais] varchar(100) NOT NULL,
    [MedicoId] varchar(100) NOT NULL,
    [EnderecoId] varchar(100) NOT NULL,
    CONSTRAINT [PK_Endereco] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Endereco_Medico_MedicoId] FOREIGN KEY ([MedicoId]) REFERENCES [Medico] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [MedicoEspecialidade] (
    [Id] varchar(100) NOT NULL,
    [MedicoId] varchar(100) NOT NULL,
    [EspecialidadeId] varchar(100) NOT NULL,
    CONSTRAINT [PK_MedicoEspecialidade] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_MedicoEspecialidade_Especialidade_EspecialidadeId] FOREIGN KEY ([EspecialidadeId]) REFERENCES [Especialidade] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MedicoEspecialidade_Medico_MedicoId] FOREIGN KEY ([MedicoId]) REFERENCES [Medico] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [TelefoneMedico] (
    [Id] varchar(100) NOT NULL,
    [MedicoId] varchar(100) NOT NULL,
    [TelefoneId] varchar(100) NOT NULL,
    CONSTRAINT [PK_TelefoneMedico] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TelefoneMedico_Medico_MedicoId] FOREIGN KEY ([MedicoId]) REFERENCES [Medico] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TelefoneMedico_Telefone_TelefoneId] FOREIGN KEY ([TelefoneId]) REFERENCES [Telefone] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [TelefonePaciente] (
    [Id] varchar(100) NOT NULL,
    [PacienteId] varchar(100) NOT NULL,
    [TelefoneId] varchar(100) NOT NULL,
    CONSTRAINT [PK_TelefonePaciente] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TelefonePaciente_Paciente_PacienteId] FOREIGN KEY ([PacienteId]) REFERENCES [Paciente] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TelefonePaciente_Telefone_TelefoneId] FOREIGN KEY ([TelefoneId]) REFERENCES [Telefone] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [PacienteTipoPagamento] (
    [Id] varchar(100) NOT NULL,
    [PacienteId] varchar(100) NOT NULL,
    [TipoPagamentoId] varchar(100) NOT NULL,
    CONSTRAINT [PK_PacienteTipoPagamento] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PacienteTipoPagamento_Paciente_PacienteId] FOREIGN KEY ([PacienteId]) REFERENCES [Paciente] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_PacienteTipoPagamento_TipoPagamento_TipoPagamentoId] FOREIGN KEY ([TipoPagamentoId]) REFERENCES [TipoPagamento] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Clinica] (
    [Id] varchar(100) NOT NULL,
    [Nome] varchar(100) NOT NULL,
    [ClinicaId] varchar(100) NOT NULL,
    CONSTRAINT [PK_Clinica] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Clinica_Endereco_ClinicaId] FOREIGN KEY ([ClinicaId]) REFERENCES [Endereco] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Consulta] (
    [Id] varchar(100) NOT NULL,
    [MedicoId] varchar(100) NOT NULL,
    [ClinicaId] varchar(100) NOT NULL,
    [PacienteId] varchar(100) NOT NULL,
    [Data] datetime2 NOT NULL,
    CONSTRAINT [PK_Consulta] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Consulta_Clinica_ClinicaId] FOREIGN KEY ([ClinicaId]) REFERENCES [Clinica] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Consulta_Medico_MedicoId] FOREIGN KEY ([MedicoId]) REFERENCES [Medico] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Consulta_Paciente_PacienteId] FOREIGN KEY ([PacienteId]) REFERENCES [Paciente] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [TelefoneClinica] (
    [Id] varchar(100) NOT NULL,
    [ClinicaId] varchar(100) NOT NULL,
    [TelefoneId] varchar(100) NOT NULL,
    CONSTRAINT [PK_TelefoneClinica] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TelefoneClinica_Clinica_ClinicaId] FOREIGN KEY ([ClinicaId]) REFERENCES [Clinica] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TelefoneClinica_Telefone_TelefoneId] FOREIGN KEY ([TelefoneId]) REFERENCES [Telefone] ([Id]) ON DELETE NO ACTION
);
GO

CREATE UNIQUE INDEX [IX_Clinica_ClinicaId] ON [Clinica] ([ClinicaId]);
GO

CREATE INDEX [IX_Consulta_ClinicaId] ON [Consulta] ([ClinicaId]);
GO

CREATE INDEX [IX_Consulta_MedicoId] ON [Consulta] ([MedicoId]);
GO

CREATE UNIQUE INDEX [IX_Consulta_PacienteId] ON [Consulta] ([PacienteId]);
GO

CREATE UNIQUE INDEX [IX_Endereco_MedicoId] ON [Endereco] ([MedicoId]);
GO

CREATE INDEX [IX_MedicoEspecialidade_EspecialidadeId] ON [MedicoEspecialidade] ([EspecialidadeId]);
GO

CREATE INDEX [IX_MedicoEspecialidade_MedicoId] ON [MedicoEspecialidade] ([MedicoId]);
GO

CREATE INDEX [IX_PacienteConvenio_ConvenioId] ON [PacienteConvenio] ([ConvenioId]);
GO

CREATE INDEX [IX_PacienteTipoPagamento_PacienteId] ON [PacienteTipoPagamento] ([PacienteId]);
GO

CREATE INDEX [IX_PacienteTipoPagamento_TipoPagamentoId] ON [PacienteTipoPagamento] ([TipoPagamentoId]);
GO

CREATE INDEX [IX_TelefoneClinica_ClinicaId] ON [TelefoneClinica] ([ClinicaId]);
GO

CREATE INDEX [IX_TelefoneClinica_TelefoneId] ON [TelefoneClinica] ([TelefoneId]);
GO

CREATE INDEX [IX_TelefoneMedico_MedicoId] ON [TelefoneMedico] ([MedicoId]);
GO

CREATE INDEX [IX_TelefoneMedico_TelefoneId] ON [TelefoneMedico] ([TelefoneId]);
GO

CREATE INDEX [IX_TelefonePaciente_PacienteId] ON [TelefonePaciente] ([PacienteId]);
GO

CREATE INDEX [IX_TelefonePaciente_TelefoneId] ON [TelefonePaciente] ([TelefoneId]);
GO

CREATE INDEX [IX_TipoPagamento_ConveniosId] ON [TipoPagamento] ([ConveniosId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221009090950_Initial', N'6.0.9');
GO

COMMIT;
GO

