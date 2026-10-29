using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

public class ConexaoBanco
{
    // ==========================================================
    // DESAFIO 0: Preencher a connection string
    // ==========================================================
    // Dica: Com SQLite não precisa instalar nada!
    // O banco é um simples arquivo .db que o programa cria sozinho.
    // private string _connectionString = "Data Source=meujogo.db;";

    // >>> ESCREVA SEU CÓDIGO AQUI <<<


    // ==========================================================
    // BANCO AUTOMÁTICO (JÁ PRONTO - não precisa mexer)
    // Cria o arquivo meujogo.db e a tabela jogadores,
    // caso ainda não existam.
    // ==========================================================
    public void CriarTabelaJogadores()
    {
        using (var conn = new SqliteConnection(_connectionString))
        {
            conn.Open();
            string sql = @"
                CREATE TABLE IF NOT EXISTS jogadores (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nome TEXT NOT NULL,
                    email TEXT NOT NULL UNIQUE,
                    nivel INTEGER NOT NULL DEFAULT 1
                );";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    // ==========================================================
    // DESAFIO 1: Cadastrar um novo jogador
    // ==========================================================
    // Objetivo: Inserir um jogador na tabela usando parâmetros.
    // Dica: Use @nome, @email e @nivel (proteção contra SQL Injection!)
    // Passos:
    //   1. Abrir a conexão (using var conn = new SqliteConnection(_connectionString))
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
    //      cada jogador na lista usando o indexador do reader:
    //      Id = Convert.ToInt32(reader["id"]),
    //      Nome = Convert.ToString(reader["nome"]) ?? "",
    //      ...
    //   4. Devolver a lista

    public List<Jogador> ListarJogadores()
    {
        // >>> ESCREVA SEU CÓDIGO AQUI <<<

        return new List<Jogador>(); // VALOR PADRÃO - troque pela lista preenchida
    }

    // ==========================================================
    // DESAFIO 3: Atualizar o nível de um jogador
    // ==========================================================
    // Objetivo: Alterar o nível de um jogador pelo id.
    // Dica: Use o comando UPDATE
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