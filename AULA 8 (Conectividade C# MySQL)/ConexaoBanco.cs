using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class ConexaoBanco
{
    // ==========================================================
    // DESAFIO 0: Preencher a connection string
    // ==========================================================
    // Dica: Ajuste apenas a senha (Pwd) para a senha do seu MySQL.
    // Se o MySQL estiver em outra máquina, troque também o Server.
    // private string _connectionString = "Server=localhost;Database=meujogo;Uid=root;Pwd=SUA_SENHA;";

    // >>> ESCREVA SEU CÓDIGO AQUI <<<


    // ==========================================================
    // DESAFIO 1: Listar todos os jogadores
    // ==========================================================
    // Objetivo: Buscar todos os jogadores da tabela e devolver
    //           como List<Jogador>.
    // Passos:
    //   1. Criar uma List<Jogador>
    //   2. Abrir a conexão (using var conn = new MySqlConnection(_connectionString))
    //   3. conn.Open()
    //   4. Executar: SELECT id, nome, email, nivel FROM jogadores
    //   5. Percorrer o reader com while (reader.Read()) e adicionar
    //      o jogador na lista usando o object initializer
    //   6. Devolver a lista

    public List<Jogador> ListarJogadores()
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<

        return null; // REMOVA esta linha quando terminar
    }

    // ==========================================================
    // DESAFIO 2: Inserir um novo jogador
    // ==========================================================
    // Objetivo: Inserir um jogador na tabela usando parâmetros.
    // Dica: Use @nome, @email e @nivel nos parâmetros para
    //       proteger contra SQL Injection!
    // Passos:
    //   1. Abrir a conexão
    //   2. Executar: INSERT INTO jogadores (nome, email, nivel)
    //                VALUES (@nome, @email, @nivel)
    //   3. Adicionar os parâmetros com cmd.Parameters.AddWithValue
    //   4. cmd.ExecuteNonQuery()

    public void InserirJogador(Jogador jogador)
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<
    }

    // ==========================================================
    // DESAFIO EXTRA 1: Listar personagens de um jogador
    // ==========================================================
    // Objetivo: Buscar os personagens de um jogador pelo id.
    // Dica: Use WHERE jogador_id = @jogadorId
    // Colunas: id, nome, classe, nivel (tabela personagens)

    public List<Personagem> ListarPersonagensDoJogador(int jogadorId)
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<

        return null; // REMOVA esta linha quando terminar
    }

    // ==========================================================
    // DESAFIO EXTRA 2: Listar itens de um personagem (JOIN)
    // ==========================================================
    // Objetivo: Retornar para a aula da semana que vem! :D
    // Use o JOIN da Aula 7:
    //   SELECT p.nome, i.nome, i.tipo, i.valor, inv.quantidade
    //   FROM inventario inv
    //   INNER JOIN personagens p ON inv.personagem_id = p.id
    //   INNER JOIN itens i ON inv.item_id = i.id
    //   WHERE p.nome = @nomePersonagem

    public void ListarItensDoPersonagem(string nomePersonagem)
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<
    }
}