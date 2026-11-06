using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é o seu nome? ");
        String nome = Console.ReadLine();
        Console.Write("Qual é o seu sobrenome? ");
        String sobrenome = Console.ReadLine();
        Console.Write($"Seu nome é {sobrenome}, {nome} {sobrenome}.");
        
            
        
    }
}