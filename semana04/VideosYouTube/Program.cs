using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Venham ao Senhor em Sua santa casa", "Gerrit W. Gong", 684);
        video1.AdicionarComentario(new Comentario("Maria Almeida", "A mensagem me inspirou a ir ao templo mais frequentemente."));
        video1.AdicionarComentario(new Comentario("João Santos", "Que ensinamento maravilhoso sobre fazer convênios."));
        video1.AdicionarComentario(new Comentario("Ana Lima", "Senti paz ao ouvir este discurso."));
        videos.Add(video1);

        Video video2 = new Video("A escultura da nossa alma", "Tamara W. Runia", 524);
        video2.AdicionarComentario(new Comentario("Carlos Pereira", "Essa mensagem me ajudou a ver meus desafios de outra forma."));
        video2.AdicionarComentario(new Comentario("Fernanda Rocha", "Preciso desenvolver mais paciência comigo mesma."));
        video2.AdicionarComentario(new Comentario("Lucas Oliveira", "Linda analogia sobre o crescimento espiritual."));
        videos.Add(video2);

        Video video3 = new Video("O dom do testemunho", "Gérald Caussé", 704);
        video3.AdicionarComentario(new Comentario("Beatriz Souza", "Vou trabalhar mais no fortalecimento do meu testemunho."));
        video3.AdicionarComentario(new Comentario("Rafael Costa", "Uma mensagem simples e muito poderosa."));
        video3.AdicionarComentario(new Comentario("Mariana Alves", "Compartilhei esse discurso com minha família."));
        videos.Add(video3);

        Video video4 = new Video("Profetas, videntes e reveladores", "Vaiangina Sikahema", 536);
        video4.AdicionarComentario(new Comentario("Gabriel Mendes", "Muito edificante aprender sobre o chamado dos profetas."));
        video4.AdicionarComentario(new Comentario("Letícia Campos", "Que bênção temos ao ouvir palavras dos profetas."));
        video4.AdicionarComentario(new Comentario("Fernando Ribeiro", "Vou estudar esta mensagem com minha família."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.ExibirInformacoes();
            Console.WriteLine();
        }
    }
}