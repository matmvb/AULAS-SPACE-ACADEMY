-- ============================================
-- AULA 7 – Banco de Dados de Jogo (RESOLVIDO)
-- Arquivo: 03_consultas.sql
-- ============================================

-- ==========================================================
-- DESAFIO 1: Listar todos os itens de um personagem
-- ==========================================================
SELECT
    p.nome AS personagem,
    i.nome AS item,
    i.tipo,
    i.valor,
    inv.quantidade
FROM inventario inv
INNER JOIN personagens p ON inv.personagem_id = p.id
INNER JOIN itens i ON inv.item_id = i.id
WHERE p.nome = 'Thorin';

-- ==========================================================
-- DESAFIO 2: Encontrar o jogador com mais personagens
-- ==========================================================
SELECT
    j.nome AS jogador,
    j.email,
    COUNT(p.id) AS total_personagens
FROM jogadores j
LEFT JOIN personagens p ON j.id = p.jogador_id
GROUP BY j.id, j.nome, j.email
ORDER BY total_personagens DESC
LIMIT 1;

-- ==========================================================
-- DESAFIO EXTRA: Listar todos os jogadores com seus personagens
-- ==========================================================
SELECT
    j.nome AS jogador,
    p.nome AS personagem,
    p.classe,
    p.nivel
FROM jogadores j
INNER JOIN personagens p ON j.id = p.jogador_id
ORDER BY j.nome, p.nome;