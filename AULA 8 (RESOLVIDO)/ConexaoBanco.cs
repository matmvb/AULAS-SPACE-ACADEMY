using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

public class ConexaoBanco
{
    // ==========================================================
    // DESAFIO 0 (RESOLVIDO): Connection string
    // ==========================================================
    // Com SQLite não precisa instalar nada:
    // o banco é um arquivo .db que o programa cria sozinho.
    private string _connectionString = "Data Source=meujogo.db;";

    // ==========================================================
    // BANCO AUTOMÁTICO (já pronto): cria a tabela se não existir
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
    // DESAFIO 1 (RESOLVIDO): Cadastrar um novo jogador
    // ==========================================================
    public void InserirJogador(Jogador jogador)
    {
        using (var conn = new SqliteConnection(_connectionString))
        {
            conn.Open();
            string sql = "INSERT INTO jogadores (nome, email, nivel) VALUES (@nome, @email, @nivel)";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", jogador.Nome);
                cmd.Parameters.AddWithValue("@email", jogador.Email);
                cmd.Parameters.AddWithValue("@nivel", jogador.Nivel);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // ==========================================================
    // DESAFIO 2 (RESOLVIDO): Listar todos os jogadores
    // ==========================================================
    public List<Jogador> ListarJogadores()
    {
        List<Jogador> lista = new List<Jogador>();

        using (var conn = new SqliteConnection(_connectionString))
        {
            conn.Open();
            string sql = "SELECT id, nome, email, nivel FROM jogadores";
            using (var cmd = new SqliteCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // No SQLite o reader não tem GetInt32("coluna"):
                    // usamos o indexador reader["coluna"] + Convert
                    lista.Add(new Jogador
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"]) ?? "",
                        Email = Convert.ToString(reader["email"]) ?? "",
                        Nivel = Convert.ToInt32(reader["nivel"])
                    });
                }
            }
        }

        return lista;
    }

    // ==========================================================
    // DESAFIO 3 (RESOLVIDO): Atualizar o nível de um jogador
    // ==========================================================
    public void AtualizarNivel(int id, int novoNivel)
    {
        using (var conn = new SqliteConnection(_connectionString))
        {
            conn.Open();
            string sql = "UPDATE jogadores SET nivel = @nivel WHERE id = @id";
            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nivel", novoNivel);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}