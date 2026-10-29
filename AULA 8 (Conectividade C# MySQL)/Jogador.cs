using System;

public class Jogador
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Nivel { get; set; }

    public override string ToString()
    {
        return $"[{Id}] {Nome} ({Email}) - Nível {Nivel}";
    }
}