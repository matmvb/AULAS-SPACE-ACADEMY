# 🔌 AULA 8 – Desafio: Conectividade C# + MySQL

Bem-vindo(a), aluno(a)! Nesta aula vamos conectar nossos programas C# ao banco de dados MySQL criado na Aula 7!

## 🎯 Desafio

Crie um programa de console com um menu que permite:

1. **Cadastrar um novo jogador**
2. **Listar todos os jogadores**
3. **Atualizar o nível de um jogador**

## 🧰 Pré-requisitos

- ✅ MySQL instalado e rodando (com a senha do `root` em mãos)
- ✅ Banco `meujogo` criado (use os arquivos SQL da Aula 7)
- ✅ .NET 10 instalado (já usado na Aula 6)

## 📌 Passo a passo

### 1. Criar o projeto

Abra o terminal **na pasta desta aula** e crie o projeto:

```bash
dotnet new console --name Aula8Conectividade -o Aula8Conectividade
```

> Se preferir, já deixamos o arquivo `Aula8Conectividade.csproj` pronto para você.

### 2. Instalar o conector MySQL

```bash
dotnet add package MySql.Data
```

### 3. Copiar os arquivos da aula

Copie `Jogador.cs`, `ConexaoBanco.cs` e `Program.cs` para dentro do projeto criado.

### 4. Completar os desafios

- **Desafio 0**: Preencher a `connection string` (sua senha do MySQL)
- **Desafio 1**: Implementar `InserirJogador()` (INSERT com parâmetros `@nome`, `@email`, `@nivel`)
- **Desafio 2**: Implementar `ListarJogadores()` (SELECT com `reader`)
- **Desafio 3**: Implementar `AtualizarNivel()` (UPDATE com `@nivel` e `@id`)

### 5. Rodar

```bash
dotnet run
```

## 🏆 Desafios

| # | Desafio | Conceito SQL |
|---|---------|--------------|
| 0 | Configurar a connection string | `MySqlConnection` |
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

Use `using` ("using var conn = new MySqlConnection(...)") para garantir que a conexão seja **fechada automaticamente**, mesmo se ocorrer um erro.

## 🎯 Resultado esperado

O menu deve permitir:

1. **Cadastrar Novo Jogador** → pede os dados e salva no banco (depois confira no MySQL Workbench!)
2. **Listar Todos os Jogadores** → mostra todos os jogadores do banco
3. **Atualizar o Nível de um Jogador** → pede o id e o novo nível e altera no banco