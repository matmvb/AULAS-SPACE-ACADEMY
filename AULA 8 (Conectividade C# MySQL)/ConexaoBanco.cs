using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class ConexaoBanco
{
    // ==========================================================
    // DESAFIO 0: Preencher a connection string
    // ==========================================================
    // Dica: Ajuste apenas a senha (Pwd) para a senha do seu MySQL.
    // private string _connectionString = "Server=localhost;Database=meujogo;Uid=root;Pwd=SUA_SENHA;";

    // >>> ESCREVA SEU CÓDIGO AQUI <<<


    // ==========================================================
    // DESAFIO 1: Cadastrar um novo jogador
    // ==========================================================
    // Objetivo: Inserir um jogador na tabela usando parâmetros.
    // Dica: Use @nome, @email e @nivel (proteção contra SQL Injection!)
    // Passos:
    //   1. Abrir a conexão (using var conn = new MySqlConnection(_connectionString))
    //   2. conn.Open()
    //   3. Executar: INSERT INTO jogadores (nome, email, nivel)
    //                VALUES (@nome, @email, @nivel)
    //   4. Adicionar os parâmetros com cmd.Parameters.AddWithValue
    //   5. cmd.ExecuteNonQuery()

    public void InserirJogador(Jogador jogador)
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<
    }

    // ==========================================================
    // DESAFIO 2: Listar todos os jogadores
    // ==========================================================
    // Objetivo: Buscar todos os jogadores e devolver como List<Jogador>.
    // Passos:
    //   1. Criar uma List<Jogador>
    //   2. Abrir a conexão e executar:
    //      SELECT id, nome, email, nivel FROM jogadores
    //   3. Percorrer o reader com while (reader.Read()) e adicionar
    //      cada jogador na lista usando o object initializer:
    //      new Jogador { Id = reader.GetInt32("id"), ... }
    //   4. Devolver a lista

    public List<Jogador> ListarJogadores()
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<

        return null; // REMOVA esta linha quando terminar
    }

    // ==========================================================
    // DESAFIO 3: Atualizar o nível de um jogador
    // ==========================================================
    // Objetivo: Alterar o nível de um jogador pelo id.
    // Dica: Use o camando UPDATE
    // Passos:
    //   1. Abrir a conexão
    //   2. Executar: UPDATE jogadores SET nivel = @nivel WHERE id = @id
    //   3. Adicionar os parâmetros @nivel e @id
    //   4. cmd.ExecuteNonQuery()

    public void AtualizarNivel(int id, int novoNivel)
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<
    }
}