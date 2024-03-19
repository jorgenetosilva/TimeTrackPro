INSERT INTO cidade (nome) VALUES
('São Paulo'),
('Rio de Janeiro'),
('Belo Horizonte'),
('Porto Alegre'),
('Curitiba'),
('Manaus'),
('Recife'),
('Salvador'),
('Fortaleza'),
('Brasília');

INSERT INTO empresa (nome) VALUES
('Tech Innovations'),
('Creative Solutions'),
('Green Tech'),
('Future Buildings'),
('Smart Systems'),
('Cloud Services'),
('Data Analytics'),
('Eco Energy'),
('Space Explorers'),
('Ocean Tech');

INSERT INTO empresa_cidade (empresa_id, cidade_id, endereco, cep, bairro, estado, complemento) VALUES
(1, 1, 'Av. Paulista, 1000', '01310-000', 'Bela Vista', 'São Paulo', 'Andar 10'),
(2, 2, 'Rua do Ouvidor, 50', '20040-030', 'Centro', 'Rio de Janeiro', 'Sala 101'),
(3, 3, 'Av. Afonso Pena, 400', '30130-007', 'Centro', 'Minas Gerais', 'Bloco B'),
(4, 4, 'Rua dos Andradas, 1234', '90020-008', 'Centro Histórico', 'Rio Grande do Sul', 'Lado ímpar'),
(5, 5, 'Rua XV de Novembro, 891', '80020-310', 'Centro', 'Paraná', 'Próximo ao Teatro'),
(6, 6, 'Av. Brasil, 600', '69029-000', 'Compensa', 'Amazonas', 'Em frente ao parque'),
(7, 7, 'Praça da Independência, 10', '50010-040', 'São José', 'Pernambuco', 'Ao lado da igreja'),
(8, 8, 'Av. Sete de Setembro, 245', '40060-001', 'Comercio', 'Bahia', 'Edifício Colombo'),
(9, 9, 'Rua da Praia, 67', '60060-170', 'Meireles', 'Ceará', 'Esquina com Av. Beira Mar'),
(10, 10, 'Eixo Monumental, 200', '70070-350', 'Zona Cívico-Administrativa', 'Distrito Federal', 'Próximo ao Congresso Nacional');

INSERT INTO categoria (nome) VALUES
('Informática'),
('Construção Civil'),
('Marketing Digital'),
('Recursos Humanos'),
('Finanças'),
('Saúde'),
('Educação'),
('Turismo'),
('Gastronomia'),
('Agricultura');

INSERT INTO atividade (nome, categoria_id) VALUES
('Desenvolvimento de Website', 1),
('Reforma de Escritório', 2),
('Campanha de SEO', 3),
('Treinamento de Equipe', 4),
('Análise de Balanço', 5),
('Consultoria Nutricional', 6),
('Elaboração de Material Didático', 7),
('Planejamento de Roteiros', 8),
('Curso de Culinária', 9),
('Implementação de Sistemas de Irrigação', 10);

-- Assumindo que os tempos gastos são representações fictícias e aleatórias
INSERT INTO registro_tempo (usuario_id, atividade_id, empresa_cidade_empresa_id, empresa_cidade_cidade_id, tempo_gasto) VALUES
(1, 1, 1, 1, INTERVAL '2 hours'),
(2, 2, 2, 2, INTERVAL '3 hours 30 minutes'),
(3, 3, 3, 3, INTERVAL '1 hour'),
(4, 4, 4, 4, INTERVAL '4 hours 45 minutes'),
(5, 5, 5, 5, INTERVAL '2 hours 15 minutes'),
(6, 6, 6, 6, INTERVAL '5 hours'),
(7, 7, 7, 7, INTERVAL '3 hours 20 minutes'),
(8, 8, 8, 8, INTERVAL '6 hours'),
(9, 9, 9, 9, INTERVAL '1 hour 50 minutes'),
(10, 10, 10, 10, INTERVAL '4 hours 10 minutes');

INSERT INTO usuario (nome, sobrenome, matricula) VALUES
('Carlos', 'Silva', 'MAT001'),
('Maria', 'Oliveira', 'MAT002'),
('João', 'Santos', 'MAT003'),
('Ana', 'Costa', 'MAT004'),
('Luiz', 'Souza', 'MAT005'),
('Patricia', 'Lima', 'MAT006'),
('Marcos', 'Rocha', 'MAT007'),
('Fernanda', 'Andrade', 'MAT008'),
('Roberto', 'Pereira', 'MAT009'),
('Juliana', 'Almeida', 'MAT010');