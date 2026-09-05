using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE INVENTÁRIO ===\n");

        // ============================================================
        // PASSO 1: Criar a lista de itens
        // ============================================================
        List<Item> itens = new List<Item>
        {
            new Item("Espada Longa", "Arma", 100),
            new Item("Poção de Cura", "Poção", 30),
            new Item("Escudo de Ferro", "Escudo", 80),
            new Item("Machado", "Arma", 120),
            new Item("Poção de Mana", "Poção", 40),
            new Item("Elmo de Prata", "Armadura", 150),
            new Item("Adaga", "Arma", 45),
            new Item("Armadura de Diamante", "Armadura", 500),
            new Item("Capacete de Cota de Malha", "Armadura", 60),
        };

        // ============================================================
        // PASSO 2: Criar dicionário para controlar quantidades
        // ============================================================
        Dictionary<string, int> quantidades = new Dictionary<string, int>();

        foreach (var item in itens)
        {
            if (quantidades.ContainsKey(item.Nome))
            {
                quantidades[item.Nome]++;
            }
            else
            {
                quantidades[item.Nome] = 1;
            }
        }

        // ============================================================
        // PASSO 3: Exibir todos os itens com suas quantidades
        // ============================================================
        Console.WriteLine("📦 INVENTÁRIO COMPLETO:");
        Console.WriteLine("----------------------------------------");
        foreach (var item in itens)
        {
            Console.WriteLine($"- {item} | Quantidade: {quantidades[item.Nome]}");
        }
        Console.WriteLine();

        // ============================================================
        // EXERCÍCIO 1: Filtrar apenas as armas (LINQ Where)
        // ============================================================
        Console.WriteLine("🗡️ EXERCÍCIO 1 - ARMAS:");
        Console.WriteLine("----------------------------------------");
        var armas = itens.Where(i => i.Tipo == "Arma");
        foreach (var arma in armas)
        {
            Console.WriteLine($"- {arma}");
        }
        Console.WriteLine();

        // ============================================================
        // EXERCÍCIO 2: Ordenar por valor (maior para menor)
        // ============================================================
        Console.WriteLine("💰 EXERCÍCIO 2 - ITENS POR VALOR (MAIOR PARA MENOR):");
        Console.WriteLine("----------------------------------------");
        var itensOrdenados = itens.OrderByDescending(i => i.Valor);
        foreach (var item in itensOrdenados)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine();

        // ============================================================
        // EXERCÍCIO 3: Top 3 itens mais valiosos (LINQ Take)
        // ============================================================
        Console.WriteLine("🏆 EXERCÍCIO 3 - TOP 3 ITENS MAIS VALIOSOS:");
        Console.WriteLine("----------------------------------------");
        var top3 = itens.OrderByDescending(i => i.Valor).Take(3);
        int posicao = 1;
        foreach (var item in top3)
        {
            Console.WriteLine($"#{posicao} - {item}");
            posicao++;
        }
        Console.WriteLine();

        // ============================================================
        // DESAFIO EXTRA: Agrupar itens por tipo (LINQ GroupBy)
        // ============================================================
        Console.WriteLine("📊 DESAFIO EXTRA - RELATÓRIO POR TIPO:");
        Console.WriteLine("----------------------------------------");
        var grupoPorTipo = itens.GroupBy(i => i.Tipo);
        foreach (var grupo in grupoPorTipo)
        {
            Console.WriteLine($"{grupo.Key}: {grupo.Count()} itens");
            Console.WriteLine($"  Valor total: {grupo.Sum(i => i.Valor)} moedas");
            Console.WriteLine($"  Média de valor: {grupo.Average(i => i.Valor):F2} moedas");
        }
        Console.WriteLine();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}