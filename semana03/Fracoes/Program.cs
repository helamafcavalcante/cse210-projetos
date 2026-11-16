using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Fracoes.");
        Fracao fracao1 = new Fracao();

        Fracao fracao2 = new Fracao(5);

        Fracao fracao3 = new Fracao(3, 4);

        Fracao fracao = new Fracao(1, 3);

        Console.WriteLine(fracao1.ObterFracaoEmTexto());
        Console.WriteLine(fracao1.ObterFracaoEmDecimal());

        Console.WriteLine(fracao2.ObterFracaoEmTexto());
        Console.WriteLine(fracao2.ObterFracaoEmDecimal());

        Console.WriteLine(fracao3.ObterFracaoEmTexto());
        Console.WriteLine(fracao3.ObterFracaoEmDecimal());       

        Console.WriteLine(fracao.ObterFracaoEmTexto());
        Console.WriteLine(fracao.ObterFracaoEmDecimal());

    }
}