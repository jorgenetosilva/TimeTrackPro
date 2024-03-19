CREATE TABLE cidade (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

CREATE TABLE empresa (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

CREATE TABLE empresa_cidade (
    empresa_id INTEGER NOT NULL,
    cidade_id INTEGER NOT NULL,
    endereco VARCHAR(255) NOT NULL,
    cep VARCHAR(20) NOT NULL,
    bairro VARCHAR(100) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    complemento VARCHAR(255),
    PRIMARY KEY (empresa_id, cidade_id),
    FOREIGN KEY (empresa_id) REFERENCES empresa(id),
    FOREIGN KEY (cidade_id) REFERENCES cidade(id)
);

CREATE TABLE categoria (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

CREATE TABLE usuario (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

CREATE TABLE atividade (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    categoria_id INTEGER,
    FOREIGN KEY (categoria_id) REFERENCES categoria(id)
);

CREATE TABLE registro_tempo (
    id SERIAL PRIMARY KEY,
    usuario_id INTEGER NOT NULL,
    atividade_id INTEGER NOT NULL,
    empresa_cidade_empresa_id INTEGER NOT NULL,
    empresa_cidade_cidade_id INTEGER NOT NULL,
    tempo_gasto INTERVAL NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES usuario(id),
    FOREIGN KEY (atividade_id) REFERENCES atividade(id),
    FOREIGN KEY (empresa_cidade_empresa_id, empresa_cidade_cidade_id) REFERENCES empresa_cidade(empresa_id, cidade_id)
);
