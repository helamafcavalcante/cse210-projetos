using System;
using System.Collections.Generic;

public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracao;
    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterNumeroDeComentarios()
    {
        return _comentarios.Count;
    }

    public void ExibirComentarios()
    {
        foreach (Comentario comentario in _comentarios)
        {
            comentario.Exibir();
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracao} segundos");
        Console.WriteLine($"Número de comentários: {ObterNumeroDeComentarios()}");
        Console.WriteLine("Comentários:");
        ExibirComentarios();
    }
}
