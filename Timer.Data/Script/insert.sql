-- Insere 10 registros na tabela empresa_detalhes
INSERT INTO empresa_detalhes (nome_empresa, nome_cidade, endereco, cep, bairro, estado, complemento) VALUES
('Tech Innovations', 'São Paulo', 'Av. Paulista, 1000', '01310-000', 'Bela Vista', 'SP', 'Andar 10'),
('Creative Solutions', 'Rio de Janeiro', 'Rua do Ouvidor, 50', '20040-030', 'Centro', 'RJ', 'Sala 101'),
('Green Tech', 'Belo Horizonte', 'Av. Afonso Pena, 400', '30130-007', 'Centro', 'MG', 'Bloco B'),
('Future Buildings', 'Porto Alegre', 'Rua dos Andradas, 1234', '90020-008', 'Centro Histórico', 'RS', 'Lado ímpar'),
('Smart Systems', 'Curitiba', 'Rua XV de Novembro, 891', '80020-310', 'Centro', 'PR', 'Próximo ao Teatro'),
('Cloud Services', 'Manaus', 'Av. Brasil, 600', '69029-000', 'Compensa', 'AM', 'Em frente ao parque'),
('Data Analytics', 'Recife', 'Praça da Independência, 10', '50010-040', 'São José', 'PE', 'Ao lado da igreja'),
('Eco Energy', 'Salvador', 'Av. Sete de Setembro, 245', '40060-001', 'Comercio', 'BA', 'Edifício Colombo'),
('Space Explorers', 'Fortaleza', 'Rua da Praia, 67', '60060-170', 'Meireles', 'CE', 'Esquina com Av. Beira Mar'),
('Ocean Tech', 'Brasília', 'Eixo Monumental, 200', '70070-350', 'Zona Cívico-Administrativa', 'DF', 'Próximo ao Congresso Nacional');

-- Insere 10 registros na tabela categoria
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

-- Insere 10 registros na tabela atividade
-- Aqui estou supondo que os IDs de categoria vão de 1 a 10, de acordo com a ordem de inserção acima.
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

-- Insere 10 registros na tabela usuario
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

-- Insere 10 registros na tabela registro_tempo
-- Aqui estou supondo que os IDs para usuario, atividade e empresa_detalhes vão de 1 a 10, de acordo com a ordem de inserção acima.
INSERT INTO registro_tempo (usuario_id, atividade_id, empresa_id, tempo_gasto) VALUES
(1, 1, 1, INTERVAL '2 hours'),
(2, 2, 2, INTERVAL '3 hours'),
(3, 3, 3, INTERVAL '1 hour 30 minutes'),
(4, 4, 4, INTERVAL '2 hours 15 minutes'),
(5, 5, 5, INTERVAL '5 hours'),
(6, 6, 6, INTERVAL '3 hours 20 minutes'),
(7, 7, 7, INTERVAL '2 hours 45 minutes'),
(8, 8, 8, INTERVAL '4 hours'),
(9, 9, 9, INTERVAL '1 hour 50 minutes'),
(10, 10, 10, INTERVAL '3 hours 10 minutes');