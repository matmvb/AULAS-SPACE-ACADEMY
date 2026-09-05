using System;

public class Item
{
    // Propriedades
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public int Valor { get; set; }

    // Construtor
    public Item(string nome, string tipo, int valor)
    {
        Nome = nome;
        Tipo = tipo;
        Valor = valor;
    }

    // Método ToString() formatado
    public override string ToString()
    {
        return $"{Nome} ({Tipo}) - {Valor} moedas";
    }
}