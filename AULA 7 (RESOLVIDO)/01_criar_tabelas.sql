-- ============================================
-- AULA 7 – Banco de Dados de Jogo (RESOLVIDO)
-- Arquivo: 01_criar_tabelas.sql
-- ============================================

CREATE TABLE jogadores (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    data_cadastro DATE DEFAULT CURRENT_DATE,
    nivel INT DEFAULT 1
);

CREATE TABLE personagens (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    classe VARCHAR(30),
    nivel INT DEFAULT 1,
    jogador_id INT,
    FOREIGN KEY (jogador_id) REFERENCES jogadores(id) ON DELETE CASCADE
);

-- ==========================================================
-- DESAFIO A: Tabela de ITENS (resposta)
-- ==========================================================
CREATE TABLE itens (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    tipo VARCHAR(30) NOT NULL,
    valor INT DEFAULT 0
);

-- ==========================================================
-- DESAFIO B: Tabela de INVENTÁRIO (resposta)
-- ==========================================================
CREATE TABLE inventario (
    personagem_id INT,
    item_id INT,
    quantidade INT DEFAULT 1,
    PRIMARY KEY (personagem_id, item_id),
    FOREIGN KEY (personagem_id) REFERENCES personagens(id) ON DELETE CASCADE,
    FOREIGN KEY (item_id) REFERENCES itens(id) ON DELETE CASCADE
);