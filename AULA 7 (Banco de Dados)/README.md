# 🎮 AULA 7 – Desafio: Banco de Dados de Jogo

Bem-vindo(a), aluno(a)! Este repositório contém o desafio de SQL do **Capítulo 5 (Modelagem de Dados e SQL)**.

## 📋 Objetivo

Criar um banco de dados para um jogo com as tabelas **Jogadores**, **Personagens**, **Itens** e **Inventário**, e escrever as consultas do desafio.

## 🗂️ Arquivos do desafio

| Arquivo | O que é | O que você faz |
|---------|---------|----------------|
| `01_criar_tabelas.sql` | Criação das 4 tabelas | Preenche os DESAFIOS A e B |
| `02_inserir_dados.sql` | Dados de exemplo | Já pronto, só rodar |
| `03_consultas.sql` | Consultas do desafio | Preenche os DESAFIOS 1 e 2 |

## 📌 Instruções

1. Baixe/clone este repositório ou copie os arquivos.
2. Abra os arquivos `.sql` no **MySQL Workbench**.
3. Execute os arquivos **na ordem** numérica (01 → 02 → 03).
4. Nos arquivos `01` e `03`, complete os trechos marcados com `>>> ESCREVA SEU CÓDIGO AQUI <<<`.
5. Teste suas consultas. Se funcionar, foi aprovado no desafio! 🎉

## 🏆 Desafios

- **Desafio A**: Criar a tabela `itens`
- **Desafio B**: Criar a tabela `inventario` (tabela de ligação)
- **Desafio 1**: Listar todos os itens de um personagem
- **Desafio 2**: Encontrar o jogador com mais personagens
- **Desafio Extra**: Listar todos os jogadores com seus personagens

## 🧠 Conceitos que você vai praticar

| Conceito | Uso no desafio |
|----------|----------------|
| PRIMARY KEY | Criar as tabelas `itens` e `inventario` |
| FOREIGN KEY | Ligar `inventario` → `personagens` e `itens` |
| INNER JOIN | Listar itens de um personagem |
| LEFT JOIN | Jogador com mais personagens |
| GROUP BY + COUNT | Contar personagens por jogador |
| ORDER BY | Ordenar pelo maior número |

## 💡 Dicas de estudo em casa

- Execute os arquivos passo a passo e observe os resultados.
- Tente responder: *Por que o `inventario` é uma tabela de ligação?*
- Modifique os dados de exemplo e veja como as consultas reagem.