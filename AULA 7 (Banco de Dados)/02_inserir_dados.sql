-- ============================================
-- AULA 7 – Desafio: Banco de Dados de Jogo
-- Arquivo: 02_inserir_dados.sql
-- ============================================

-- ATENÇÃO: Este arquivo já contém os dados de exemplo.
-- Use-o para testar suas consultas.
-- Se você mudou o nome de alguma tabela, ajuste aqui também.

-- Inserir Jogadores
INSERT INTO jogadores (nome, email, nivel) VALUES
('Carlos Silva', 'carlos@email.com', 10),
('Ana Souza', 'ana@email.com', 15),
('Pedro Lima', 'pedro@email.com', 8);

-- Inserir Personagens
INSERT INTO personagens (nome, classe, nivel, jogador_id) VALUES
('Thorin', 'Guerreiro', 12, 1),
('Merlin', 'Mago', 10, 1),
('Luna', 'Arqueira', 14, 2),
('Drake', 'Guerreiro', 11, 2),
('Aria', 'Mago', 13, 2),
('Raven', 'Ladina', 9, 3);

-- Inserir Itens
INSERT INTO itens (nome, tipo, valor) VALUES
('Espada Longa', 'Arma', 150),
('Cajado Arcano', 'Arma', 200),
('Poção de Cura', 'Poção', 30),
('Escudo de Ferro', 'Armadura', 120),
('Anel de Poder', 'Acessório', 300),
('Arco Reforzado', 'Arma', 180),
('Armadura de Couro', 'Armadura', 90),
('Poção de Mana', 'Poção', 40),
('Adaga Sombria', 'Arma', 160),
('Amuleto da Sorte', 'Acessório', 250);

-- Inserir Inventário (ligação entre personagens e itens)
INSERT INTO inventario (personagem_id, item_id, quantidade) VALUES
(1, 1, 1),   -- Thorin tem Espada Longa
(1, 4, 1),   -- Thorin tem Escudo de Ferro
(1, 3, 5),   -- Thorin tem 5 Poções de Cura
(2, 2, 1),   -- Merlin tem Cajado Arcano
(2, 5, 1),   -- Merlin tem Anel de Poder
(2, 8, 3),   -- Merlin tem 3 Poções de Mana
(3, 6, 1),   -- Luna tem Arco Reforzado
(3, 7, 1),   -- Luna tem Armadura de Couro
(4, 1, 1),   -- Drake tem Espada Longa
(4, 4, 1),   -- Drake tem Escudo de Ferro
(5, 2, 1),   -- Aria tem Cajado Arcano
(5, 5, 1),   -- Aria tem Anel de Poder
(5, 8, 4),   -- Aria tem 4 Poções de Mana
(5, 10, 1),  -- Aria tem Amuleto da Sorte
(6, 9, 1),   -- Raven tem Adaga Sombria
(6, 10, 1);  -- Raven tem Amuleto da Sorte