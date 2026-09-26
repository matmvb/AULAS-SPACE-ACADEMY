using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE JOGO - C# + SQLite ===\n");

        var banco = new ConexaoBanco();

        // Cria o banco e a tabela automaticamente (se ainda não existirem)
        banco.CriarTabelaJogadores();

        string opcao;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Cadastrar Novo Jogador");
            Console.WriteLine("2 - Listar Todos os Jogadores");
            Console.WriteLine("3 - Atualizar o Nível de um Jogador");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    // DESAFIO 1 (RESOLVIDO): Cadastrar um novo jogador
                    Console.Write("\nNome do jogador: ");
                    string nome = Console.ReadLine()!;
                    Console.Write("Email: ");
                    string email = Console.ReadLine()!;
                    Console.Write("Nível: ");
                    int nivel = int.Parse(Console.ReadLine()!);

                    var novoJogador = new Jogador
                    {
                        Nome = nome,
                        Email = email,
                        Nivel = nivel
                    };
                    banco.InserirJogador(novoJogador);
                    Console.WriteLine("Jogador cadastrado com sucesso!");
                    break;

                case "2":
                    // DESAFIO 2 (RESOLVIDO): Listar todos os jogadores
                    Console.WriteLine("\n--- JOGADORES ---");
                    var jogadores = banco.ListarJogadores();
                    foreach (var jogador in jogadores)
                    {
                        Console.WriteLine($"- {jogador}");
                    }
                    break;

                case "3":
                    // DESAFIO 3 (RESOLVIDO): Atualizar o nível de um jogador
                    Console.Write("\nId do jogador: ");
                    int id = int.Parse(Console.ReadLine()!);
                    Console.Write("Novo nível: ");
                    int novoNivel = int.Parse(Console.ReadLine()!);

                    banco.AtualizarNivel(id, novoNivel);
                    Console.WriteLine("Nível atualizado com sucesso!");
                    break;

                case "0":
                    Console.WriteLine("\nSaindo... Até a próxima aula!");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }

        } while (opcao != "0");
    }
}