-- ============================================
-- AULA 7 – Banco de Dados de Jogo (RESOLVIDO)
-- Arquivo: 02_inserir_dados.sql
-- ============================================

INSERT INTO jogadores (nome, email, nivel) VALUES
('Carlos Silva', 'carlos@email.com', 10),
('Ana Souza', 'ana@email.com', 15),
('Pedro Lima', 'pedro@email.com', 8);

INSERT INTO personagens (nome, classe, nivel, jogador_id) VALUES
('Thorin', 'Guerreiro', 12, 1),
('Merlin', 'Mago', 10, 1),
('Luna', 'Arqueira', 14, 2),
('Drake', 'Guerreiro', 11, 2),
('Aria', 'Mago', 13, 2),
('Raven', 'Ladina', 9, 3);

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

INSERT INTO inventario (personagem_id, item_id, quantidade) VALUES
(1, 1, 1),
(1, 4, 1),
(1, 3, 5),
(2, 2, 1),
(2, 5, 1),
(2, 8, 3),
(3, 6, 1),
(3, 7, 1),
(4, 1, 1),
(4, 4, 1),
(5, 2, 1),
(5, 5, 1),
(5, 8, 4),
(5, 10, 1),
(6, 9, 1),
(6, 10, 1);