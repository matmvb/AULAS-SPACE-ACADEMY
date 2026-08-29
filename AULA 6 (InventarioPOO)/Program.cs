using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE INVENTÁRIO ===\n");

        // TODO: Criar uma lista de itens (List<Item>)
        // Dicas de itens:
        // - "Espada Longa", "Arma", 100
        // - "Poção de Cura", "Poção", 30
        // - "Escudo de Ferro", "Escudo", 80
        // - "Machado", "Arma", 120
        // - "Poção de Mana", "Poção", 40

        // TODO: Criar um dicionário para controlar as quantidades (Dictionary<string, int>)

        // TODO: Percorrer a lista de itens e preencher o dicionário com as quantidades

        // TODO: Exibir todos os itens do inventário

        // TODO: EXERCÍCIO 1 - Filtrar apenas as armas usando LINQ
        // var armas = itens.Where(i => i.Tipo == "Arma");
        // Exibir as armas encontradas

        // TODO: EXERCÍCIO 2 - Ordenar os itens por valor (do maior para o menor)
        // var itensOrdenados = itens.OrderByDescending(i => i.Valor);
        // Exibir os itens ordenados

        // TODO: EXERCÍCIO 3 - Encontrar os 3 itens mais valiosos
        // var top3 = itens.OrderByDescending(i => i.Valor).Take(3);
        // Exibir o Top 3

        // TODO: DESAFIO EXTRA - Agrupar os itens por tipo e mostrar a quantidade de cada tipo
        // var grupoPorTipo = itens.GroupBy(i => i.Tipo);
        // Exibir: "Armas: 2 itens", "Poções: 2 itens", etc.

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}