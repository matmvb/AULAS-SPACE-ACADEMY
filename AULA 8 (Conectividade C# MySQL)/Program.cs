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
            Console.WriteLine("1 - Cadastrar Novo Jogador");
            Console.WriteLine("2 - Listar Todos os Jogadores");
            Console.WriteLine("3 - Atualizar o Nível de um Jogador");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // DESAFIO 1: Pedir nome, email e nível do jogador,
                    // criar um objeto Jogador e chamar banco.InserirJogador(jogador)
                    // >>> ESCREVA SEU CÓDIGO AQUI <<<
                    break;

                case "2":
                    // DESAFIO 2: Chamar banco.ListarJogadores() e exibir cada jogador
                    // >>> ESCREVA SEU CÓDIGO AQUI <<<
                    break;

                case "3":
                    // DESAFIO 3: Pedir o id e o novo nível do jogador,
                    // depois chamar banco.AtualizarNivel(id, novoNivel)
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