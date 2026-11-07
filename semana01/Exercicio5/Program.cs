using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio5.");
        Console.WriteLine("Bem-vindo ao programa!");
        Console.Write("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Por favor insira Seu número favorito: ");
        int numero = int.Parse(Console.ReadLine());
        int numeroQuadrado = numero *numero;
        Console.WriteLine($"{nome}, o quadraro do seu número é {numeroQuadrado}");
    }
}