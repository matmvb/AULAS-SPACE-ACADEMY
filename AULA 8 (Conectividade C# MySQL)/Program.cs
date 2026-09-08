using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE JOGO - C# + MySQL ===\n");

        // TODO: Criar uma instância da classe ConexaoBanco
        // var banco = new ConexaoBanco();

        string opcao;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Listar Jogadores");
            Console.WriteLine("2 - Inserir Jogador");
            Console.WriteLine("3 - Listar Personagens de um Jogador");
            Console.WriteLine("4 - Listar Itens de um Personagem");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // DESAFIO 1: Chamar banco.ListarJogadores() e exibir
                    // >>> ESCREVA SEU CÓDIGO AQUI <<<
                    break;

                case "2":
                    // DESAFIO 2: Pedir nome, email e nível do jogador,
                    // criar um objeto Jogador e chamar banco.InserirJogador(jogador)
                    // >>> ESCREVA SEU CÓDIGO AQUI <<<
                    break;

                case "3":
                    // EXTRA 1: Pedir o id do jogador e chamar
                    // banco.ListarPersonagensDoJogador(id)
                    // >>> ESCREVA SEU CÓDIGO AQUI <<<
                    break;

                case "4":
                    // EXTRA 2: Pedir o nome do personagem e chamar
                    // banco.ListarItensDoPersonagem(nome)
                    // >>> ESCREVA SEU CÓDIGO AQUI <<<
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