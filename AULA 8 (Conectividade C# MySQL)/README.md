# 🔌 AULA 8 – Desafio: Conectividade C# + Banco de Dados (SQLite)

Bem-vindo(a), aluno(a)! Nesta aula vamos conectar nossos programas C# a um **banco de dados** — usando **SQLite**.

## 🚀 A grande novidade: nada de instalar banco de dados!

Ao contrário do MySQL, o **SQLite** não precisa de servidor nem instalação:

- O banco é um **único arquivo** (`meujogo.db`) que o próprio programa cria.
- A tabela `jogadores` também é criada automaticamente na primeira execução.
- Só precisa do **VS Code + .NET** (já usados desde a Aula 6).

## 🎯 Desafio

Crie um programa de console com um menu que permite:

1. **Cadastrar um novo jogador**
2. **Listar todos os jogadores**
3. **Atualizar o nível de um jogador**

## 🧰 Pré-requisitos

- ✅ VS Code
- ✅ .NET 10 instalado (já usado na Aula 6)
- ❌ Nenhum banco de dados para instalar! 😄

## 📌 Passo a passo

### 1. Preparar a pasta do projeto

Crie uma pasta chamada `Aula8Conectividade` e copie para dentro dela os arquivos desta aula:

- `Aula8Conectividade.csproj`
- `Jogador.cs`
- `ConexaoBanco.cs`
- `Program.cs`

> O arquivo `.csproj` **já vem com o pacote `Microsoft.Data.Sqlite` configurado**.

### 2. (Opcional) Instalar o pacote do zero

Se quiser praticar a instalação do pacote, crie o projeto do zero:

```bash
dotnet new console --name Aula8Conectividade -o Aula8Conectividade
dotnet add package Microsoft.Data.Sqlite
```

### 3. Completar os desafios

- **Desafio 0**: Preencher a `connection string` (basta `Data Source=meujogo.db;`)
- **Desafio 1**: Implementar `InserirJogador()` (INSERT com parâmetros `@nome`, `@email`, `@nivel`)
- **Desafio 2**: Implementar `ListarJogadores()` (SELECT com `reader`)
- **Desafio 3**: Implementar `AtualizarNivel()` (UPDATE com `@nivel` e `@id`)

### 4. Rodar

```bash
dotnet run
```

## 🏆 Desafios

| # | Desafio | Conceito SQL |
|---|---------|--------------|
| 0 | Configurar a connection string | `SqliteConnection` |
| 1 | Cadastrar um novo jogador | `INSERT` + parâmetros (`AddWithValue`) |
| 2 | Listar todos os jogadores | `SELECT` + `ExecuteReader()` |
| 3 | Atualizar o nível de um jogador | `UPDATE ... SET ... WHERE ...` |

## 🚫 Importante: SQL Injection

NUNCA monte o SQL concatenando texto do usuário:

```csharp
// ❌ ERRADO - vulnerável a SQL Injection
string sql = "SELECT * FROM jogadores WHERE email = '" + email + "'";

// ✅ CERTO - usa parâmetros
string sql = "SELECT * FROM jogadores WHERE email = @email";
cmd.Parameters.AddWithValue("@email", email);
```

## 💡 Dica do capítulo

Use `using` ("using var conn = new SqliteConnection(...)") para garantir que a conexão seja **fechada automaticamente**, mesmo se ocorrer um erro.

## 🎯 Resultado esperado

O menu deve permitir:

1. **Cadastrar Novo Jogador** → pede os dados e salva no banco
2. **Listar Todos os Jogadores** → mostra todos os jogadores do banco
3. **Atualizar o Nível de um Jogador** → pede o id e o novo nível e altera no banco

> 💾 Depois de rodar o programa, o arquivo **`meujogo.db`** é criado na pasta do projeto.
> Para ver as tabelas e os dados, basta usar o menu (opção 2) — ou, se quiser,
> instale a extensão **SQLite Viewer** no VS Code (totalmente opcional).