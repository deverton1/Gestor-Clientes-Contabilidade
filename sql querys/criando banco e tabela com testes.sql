-- Criação de uma tabela para representar empresas
CREATE TABLE Empresas (
    Id INT PRIMARY KEY IDENTITY(1,1) not null,
    RazaoSocial NVARCHAR(255) not null,
    Cnpj NVARCHAR(18) not null,
    NomeRepresentante NVARCHAR(255) not null,
    CpfRepresentante NVARCHAR(14) not null,
	CodigoSimplesNacio NVARCHAR (12) not null,
    Logradouro NVARCHAR(255) not null,
    Tributacao NVARCHAR(255) not null,
    Porte NVARCHAR(50) not null,
    DataAbertura DATE not null
);

-- Inserção de dados aleatórios
INSERT INTO Empresas (RazaoSocial, Cnpj, NomeRepresentante, CpfRepresentante, CodigoSimplesNacio, Logradouro, Tributacao, Porte, DataAbertura)
VALUES
    ('Empresa Teste 1', '12345678901234', 'Representante Teste 1', '98765432109', '123456789012', 'Rua Teste 1', 'Tributacao Teste 1', 'Porte Teste 1', '2022-01-01'),
    ('Empresa Teste 2', '98765432109876', 'Representante Teste 2', '12345678901', '987654321098', 'Rua Teste 2', 'Tributacao Teste 2', 'Porte Teste 2', '2022-01-02'),
    ('Empresa Teste 3', '11112222333344', 'Representante Teste 3', '44443333222', '555566667777', 'Rua Teste 3', 'Tributacao Teste 3', 'Porte Teste 3', '2022-01-03');

-- Adicione mais linhas conforme necessário

-- Exibição dos dados inseridos
SELECT * FROM Empresas;
