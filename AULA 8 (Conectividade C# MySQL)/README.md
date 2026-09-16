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

## 🖥️ Como conectar no MySQL Workbench

### 1. Abrir o Workbench e conectar no servidor

1. Abra o **MySQL Workbench**.
2. Clique na conexão **Local instance MySQL** (se não existir, crie: botão **+** →
   Hostname: `localhost`, Port: `3306`, User: `root`).
3. Informe a **senha do `root`** quando o Workbench pedir.

### 2. Criar o banco de dados

Em uma aba de consulta (QUERY), rode:

```sql
CREATE DATABASE meujogo;
```

### 3. Criar as tabelas e popular os dados (SQLs da Aula 7)

1. Clique em **File → Open SQL Script** e abra o arquivo `01_criar_tabelas.sql` da Aula 7.
2. Rode com **Ctrl + Shift + Enter** (ou o botão ⚡ *Execute*).
3. Repita o mesmo com o arquivo `02_inserir_dados.sql` para inserir os dados de exemplo.
4. No painel **Navigator**, clique com o botão direito em `meujogo` → **Refresh All**
   para ver as tabelas `jogadores`, `personagens`, `itens` e `inventario`.

### 4. Testar a conexão

Rode uma consulta simples para confirmar que está tudo certo:

```sql
USE meujogo;
SELECT * FROM jogadores;
```

> 💡 A **connection string** do C# precisa "bater" com essa conexão:
>
> ```csharp
> Server=localhost;Database=meujogo;Uid=root;Pwd=SUA_SENHA;
> ```
>
> Onde `SUA_SENHA` é **a mesma senha** que você digitou no Workbench.

## 📌 Passo a passo

### 1. Preparar a pasta do projeto

Crie uma pasta chamada `Aula8Conectividade` e copie para dentro dela os arquivos desta aula:

- `Aula8Conectividade.csproj`
- `Jogador.cs`
- `ConexaoBanco.cs`
- `Program.cs`

> O arquivo `.csproj` **já vem com o pacote `MySql.Data` configurado** (seção 6.1).

### 2. (Opcional) Instalar o conector do zero

Se quiser praticar a instalação do conector (seção 6.1 do capítulo), crie o projeto do zero:

```bash
dotnet new console --name Aula8Conectividade -o Aula8Conectividade
dotnet add package MySql.Data
```

### 3. Completar os desafios

- **Desafio 0**: Preencher a `connection string` (sua senha do MySQL)
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