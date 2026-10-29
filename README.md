# 🚀 SPACE ACADEMY – Aulas de Programação

Bem-vindo(a) ao repositório oficial da **Space Academy**! Aqui você encontra as atividades e desafios das aulas, para baixar em casa, praticar e estudar.

## 📥 Como acessar

### Opção 1 – Git Clone (recomendado)

```bash
git clone https://github.com/matmvb/AULAS-SPACE-ACADEMY.git
```

### Opção 2 – Download direto

1. Acesse o repositório no GitHub.
2. Clique no botão verde **Code → Download ZIP**.
3. Extraia a pasta e abra os arquivos.

Depois, para receber atualizações (novas aulas/respostas):

```bash
git pull
```

### Pegar só o desafio, sem o gabarito

O repositório publica o **desafio** de cada aula primeiro e o **gabarito** depois
(uma semana mais tarde). Se você só quer o enunciado, use a tag do desafio:

```bash
git checkout aula-7-desafio     # só o desafio da Aula 7
git checkout aula-7-gabarito    # depois, para conferir a resolução
git checkout main               # voltar para a versão mais recente
```

| Tag | Aula | Conteúdo |
|-----|------|----------|
| `aula-6-desafio` / `aula-6-gabarito` | Aula 6 | Inventário (POO + LINQ) |
| `aula-7-desafio` / `aula-7-gabarito` | Aula 7 | Banco de dados de jogo (SQL) |
| `aula-8-desafio` / `aula-8-gabarito` | Aula 8 | Conectividade C# + SQLite |

## 📚 Aulas

| Aula | Conteúdo | Status |
|------|----------|--------|
| Aula 6 | Sistema de Inventário (POO + LINQ) | ✅ Resolvido |
| Aula 7 | Banco de Dados de Jogo (SQL) | ✅ Resolvido |
| Aula 8 | Conectividade C# + SQLite | ✅ Resolvido |

> Status: 📝 = desafio para fazer · ✅ = gabarito/resolução publicado

## 🗂️ Estrutura do repositório

```
📁 AULAS SPACE ACADEMY
├── 📁 AULA 6 (RESOLVIDO)/                 → Gabarito da Aula 6 (POO + LINQ)
├── 📁 AULA 7 (Banco de Dados)/            → Material da Aula 7 (SQL)
├── 📁 AULA 7 (RESOLVIDO)/                 → Gabarito da Aula 7
├── 📁 AULA 8 (Conectividade C# MySQL)/    → Material da Aula 8
├── 📁 AULA 8 (RESOLVIDO)/                 → Gabarito da Aula 8 (C# + SQLite)
├── 📁 AULAS UNITY/                        → Projetos Unity (não versionados)
└── README.md                              → Este arquivo
```

> As pastas `bin/` e `obj/` (.NET) e as pastas internas dos projetos Unity
> (`Library/`, `Temp/`, etc.) não vão para o repositório — veja o `.gitignore`.

## ✏️ Como funcionam os desafios

- Cada aula tem uma pasta com o material do desafio.
- Responda os trechos marcados com `// TODO` ou `>>> ESCREVA SEU CÓDIGO AQUI <<<`.
- Uma semana depois, o professor publica a versão **RESOLVIDO** para você conferir.

## ✅ Qualidade do material

O workflow `.github/workflows/ci.yml` compila os projetos C# das Aulas 6 e 8 a
cada push. Se um gabarito deixar de compilar, o build fica vermelho antes de
chegar aos alunos.

## 📄 Licença

Código sob **MIT**; enunciados e material didático sob **CC BY-NC-SA 4.0**.
Veja [LICENSE.md](LICENSE.md).

## 💬 Dúvidas?

Pergunte no grupo ou na próxima aula! 🎓