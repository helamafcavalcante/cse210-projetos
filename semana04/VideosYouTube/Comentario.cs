using System;

public class Comentario
{
    private string _nome;
    private string _texto;

    public Comentario(string nome, string texto)
    {
        _nome = nome;
        _texto = texto;
    }

    public void Exibir()
    {
        Console.WriteLine($"{_nome}: {_texto}");
    }
}
