-- ============================================
-- AULA 7 – Desafio: Banco de Dados de Jogo
-- Arquivo: 01_criar_tabelas.sql
-- Aluno: ______________________________
-- ============================================

-- INSTRUÇÕES: Escreva abaixo o script para criar as 4 tabelas do banco.
-- As tabelas "jogadores" e "personagens" já estão prontas como exemplo.
-- Você deve criar as tabelas "itens" e "inventario".

-- --------------------------------------------------------
-- EXEMPLO 1: Tabela de Jogadores (já pronta)
-- --------------------------------------------------------
CREATE TABLE jogadores (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    data_cadastro DATE DEFAULT CURRENT_DATE,
    nivel INT DEFAULT 1
);

-- --------------------------------------------------------
-- EXEMPLO 2: Tabela de Personagens (já pronta)
-- --------------------------------------------------------
CREATE TABLE personagens (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    classe VARCHAR(30),
    nivel INT DEFAULT 1,
    jogador_id INT,
    FOREIGN KEY (jogador_id) REFERENCES jogadores(id) ON DELETE CASCADE
);

-- ==========================================================
-- DESAFIO A: Criar a tabela de ITENS
-- ==========================================================
-- Requisitos:
--   id    : INT, chave primária, auto incremento
--   nome  : VARCHAR(100), não nulo
--   tipo  : VARCHAR(30), não nulo (ex: 'Arma', 'Poção', 'Armadura')
--   valor : INT com valor padrão 0

-- >>> ESCREVA SEU CÓDIGO AQUI <<<


-- ==========================================================
-- DESAFIO B: Criar a tabela de INVENTÁRIO
-- ==========================================================
-- Requisitos:
--   personagem_id : INT, FK -> personagens(id)
--   item_id       : INT, FK -> itens(id)
--   quantidade    : INT com valor padrão 1
--   PRIMARY KEY composta (personagem_id, item_id)

-- >>> ESCREVA SEU CÓDIGO AQUI <<<