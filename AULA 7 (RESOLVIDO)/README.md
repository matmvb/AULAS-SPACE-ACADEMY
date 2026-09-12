# 🎮 AULA 7 – Banco de Dados de Jogo (RESOLVIDO)

Versão com as **respostas do desafio** da Aula 7 (Capítulo 5 – Modelagem de Dados e SQL). Use para conferir suas soluções e estudar!

## ⚠️ Antes de olhar as respostas

Tente resolver o desafio primeiro na versão original. Só consulte este gabarito depois de tentar — assim o aprendizado funciona de verdade! 😉

## 🗂️ Arquivos

| Arquivo | O que contém |
|---------|--------------|
| `01_criar_tabelas.sql` | Criação das 4 tabelas **completa** (Desafios A e B respondidos) |
| `02_inserir_dados.sql` | Dados de exemplo (jogadores, personagens, itens, inventário) |
| `03_consultas.sql` | Consultas **respondidas** (Desafios 1, 2 e Extra) |

## 📌 Como executar

1. Abra o **MySQL Workbench** (ou o cliente MySQL de sua preferência).
2. Crie um banco: `CREATE DATABASE meujogo;`
3. Execute os arquivos **na ordem** numérica (01 → 02 → 03).
4. Compare os resultados com os que você obteve no desafio.

## ✅ Respostas (resumo)

### Desafio A – Tabela `itens`

```sql
CREATE TABLE itens (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    tipo VARCHAR(30) NOT NULL,
    valor INT DEFAULT 0
);
```

### Desafio B – Tabela `inventario`

```sql
CREATE TABLE inventario (
    personagem_id INT,
    item_id INT,
    quantidade INT DEFAULT 1,
    PRIMARY KEY (personagem_id, item_id),
    FOREIGN KEY (personagem_id) REFERENCES personagens(id) ON DELETE CASCADE,
    FOREIGN KEY (item_id) REFERENCES itens(id) ON DELETE CASCADE
);
```

### Desafio 1 – Listar todos os itens de um personagem

```sql
SELECT p.nome AS personagem, i.nome AS item, i.tipo, i.valor, inv.quantidade
FROM inventario inv
INNER JOIN personagens p ON inv.personagem_id = p.id
INNER JOIN itens i ON inv.item_id = i.id
WHERE p.nome = 'Thorin';
```

> **Resultado esperado:** Thorin possui 3 itens (Espada Longa, Escudo de Ferro e 5 Poções de Cura).

### Desafio 2 – Encontrar o jogador com mais personagens

```sql
SELECT j.nome AS jogador, j.email, COUNT(p.id) AS total_personagens
FROM jogadores j
LEFT JOIN personagens p ON j.id = p.jogador_id
GROUP BY j.id, j.nome, j.email
ORDER BY total_personagens DESC
LIMIT 1;
```

> **Resultado esperado:** **Ana Souza** com 3 personagens (Luna, Drake e Aria).

## 🧠 Por que essas respostas funcionam?

| Conceito | Explicação |
|----------|------------|
| `INNER JOIN` | Combina as linhas que existem **nos dois lados** (inventário ↔ personagens ↔ itens) |
| `WHERE p.nome = 'Thorin'` | Filtra apenas o personagem desejado |
| `LEFT JOIN` | Mantém **todos** os jogadores, mesmo os sem personagens |
| `GROUP BY + COUNT` | Conta quantos personagens cada jogador tem |
| `ORDER BY ... DESC LIMIT 1` | Pega o maior valor e retorna só o primeiro (o campeão!) |