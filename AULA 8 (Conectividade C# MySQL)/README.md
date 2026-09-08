# 🔌 AULA 8 – Desafio: Conectividade C# + MySQL

Bem-vindo(a), aluno(a)! Nesta aula vamos conectar nossos programas C# ao banco de dados MySQL criado na Aula 7!

## 📋 Objetivo

Criar um programa C# que consiga **listar** e **inserir** dados no banco de dados do jogo usando a biblioteca `MySql.Data`.

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

Copie `Jogador.cs`, `Personagem.cs`, `ConexaoBanco.cs` e `Program.cs` para dentro do projeto criado.

### 4. Completar os desafios

- **Desafio 0**: Preencher a `connection string` (Senior: sua senha do MySQL)
- **Desafio 1**: Implementar `ListarJogadores()` (SELECT com `reader`)
- **Desafio 2**: Implementar `InserirJogador()` (INSERT com parâmetros `@nome`, `@email`, `@nivel`)

### 5. Rodar

```bash
dotnet run
```

## 🏆 Desafios

| # | Desafio | Conceito |
|---|---------|----------|
| 0 | Configurar a connection string | `MySqlConnection` |
| 1 | Listar jogadores | `SELECT` + `ExecuteReader()` |
| 2 | Inserir jogador | `INSERT` + parâmetros (`AddWithValue`) |
| Extra 1 | Listar personagens de um jogador | `WHERE` + parâmetros |
| Extra 2 | Listar itens de um personagem | `JOIN` (Aula 7!) |

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

1. **Listar Jogadores** → mostra todos os jogadores do banco
2. **Inserir Jogador** → pede os dados e salva no banco (depois confira no MySQL Workbench!)
3. **Listar Personagens de um Jogador** → mostra os personagens de um id
4. **Listar Itens de um Personagem** → mostra os itens (igual à Aula 7, agora em C#)