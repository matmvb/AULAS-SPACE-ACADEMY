# 🔌 AULA 8 – Conectividade C# + SQLite (RESOLVIDO)

Versão com as **respostas do desafio** da Aula 8. Use para conferir suas soluções e estudar!

> 🚀 Nesta versão usamos **SQLite**: não precisa instalar MySQL nem Workbench.
> O banco é um arquivo (`meujogo.db`) que o programa cria sozinho.

## ⚠️ Antes de olhar as respostas

Tente resolver o desafio primeiro na versão original. Só consulte este gabarito depois de tentar — assim o aprendizado funciona de verdade! 😉

## 🗂️ Arquivos

| Arquivo | O que contém |
|---------|--------------|
| `Aula8Conectividade.csproj` | Projeto com o pacote `Microsoft.Data.Sqlite` configurado |
| `Jogador.cs` | Classe modelo (Id, Nome, Email, Nivel) |
| `ConexaoBanco.cs` | Camada de acesso ao banco **respondida** |
| `Program.cs` | Menu **respondido** (cadastrar, listar, atualizar) |

## 📌 Como executar

1. Copie os arquivos para uma pasta de projeto (ou abra esta pasta).
2. No terminal, rode:

```bash
dotnet run
```

> 🪄 Nada de banco para configurar: o programa cria o arquivo `meujogo.db`
> e a tabela `jogadores` automaticamente na primeira execução.

## ✅ Respostas (resumo)

### Desafio 0 – Connection string

```csharp
private string _connectionString = "Data Source=meujogo.db;";
```

### Desafio 1 – Cadastrar um novo jogador

```csharp
string sql = "INSERT INTO jogadores (nome, email, nivel) VALUES (@nome, @email, @nivel)";
cmd.Parameters.AddWithValue("@nome", jogador.Nome);
cmd.Parameters.AddWithValue("@email", jogador.Email);
cmd.Parameters.AddWithValue("@nivel", jogador.Nivel);
cmd.ExecuteNonQuery();
```

### Desafio 2 – Listar todos os jogadores

Diferente do MySQL, o `SqliteDataReader` não tem `GetInt32("coluna")`.
Use o **indexador** `reader["coluna"]` com `Convert`:

```csharp
string sql = "SELECT id, nome, email, nivel FROM jogadores";
using var reader = cmd.ExecuteReader();
while (reader.Read())
{
    lista.Add(new Jogador
    {
        Id = Convert.ToInt32(reader["id"]),
        Nome = Convert.ToString(reader["nome"]) ?? "",
        Email = Convert.ToString(reader["email"]) ?? "",
        Nivel = Convert.ToInt32(reader["nivel"])
    });
}
```

### Desafio 3 – Atualizar o nível de um jogador

```csharp
string sql = "UPDATE jogadores SET nivel = @nivel WHERE id = @id";
cmd.Parameters.AddWithValue("@nivel", novoNivel);
cmd.Parameters.AddWithValue("@id", id);
cmd.ExecuteNonQuery();
```

## 🧠 Por que essas respostas funcionam?

| Conceito | Explicação |
|----------|------------|
| `using` | Fecha a conexão automaticamente, mesmo com erro |
| Parâmetros `@nome`, `@email`... | Protegem contra SQL Injection |
| `ExecuteReader()` + `reader.Read()` | Percorre as linhas retornadas pelo SELECT |
| `ExecuteNonQuery()` | Executa comandos que não retornam dados (INSERT/UPDATE) |
| `reader["coluna"]` + `Convert` | Lê o valor da coluna pelo nome no SQLite |

## 🏆 Menu esperado

```
1 - Cadastrar Novo Jogador
2 - Listar Todos os Jogadores
3 - Atualizar o Nível de um Jogador
0 - Sair
```

O programa e o banco (`meujogo.db`) devem refletir as mesmas mudanças a cada execução — os dados ficam salvos no arquivo!