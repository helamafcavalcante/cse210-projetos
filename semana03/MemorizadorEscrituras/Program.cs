// O programa possui uma biblioteca com várias escrituras
// e escolhe uma delas aleatoriamente a cada execução.

using System;

class Program
{
    static void Main(string[] args)
    {
        Escritura[] biblioteca = new Escritura[]
        {
            new Escritura(
                new Referencia("João", 3, 16),
                "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."),
            new Escritura(
                new Referencia("Salmos", 23, 1),
                "O Senhor é o meu pastor; nada me faltará."),
            new Escritura(
                new Referencia("Provérbios", 3, 5, 6),
                "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.")
        };

        Random random = new Random();

        Escritura escritura = biblioteca[random.Next(biblioteca.Length)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();

            Console.Write("Pressione Enter para ocultar palavras ou digite 'sair' para encerrar: ");

            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);

            if (escritura.EstaCompletamenteOculta())
            {
                Console.Clear();
                Console.WriteLine(escritura.ObterTexto());
                break;
            }
        }
    }
}