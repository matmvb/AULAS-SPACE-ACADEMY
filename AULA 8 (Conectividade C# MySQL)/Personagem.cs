using System;

public class Personagem
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Classe { get; set; } = string.Empty;
    public int Nivel { get; set; }
    public int JogadorId { get; set; }

    public override string ToString()
    {
        return $"[{Id}] {Nome} (Classe: {Classe}) - Nível {Nivel}";
    }
}