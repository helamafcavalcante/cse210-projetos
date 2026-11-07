using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio4.");
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar. ");
        List<int> listaNumero = new List<int>();
        int menorNumero = int.MaxValue;
        while(true)
        {
            Console.Write("Insira o número: ");
            int numeros = int.Parse(Console.ReadLine());
            if (numeros > 0 && numeros < menorNumero)
            {
                menorNumero = numeros;
            }
            if (numeros !=0)
            {
                listaNumero.Add(numeros);
            }
            else
            {
                break;
            }
        }
        int soma = 0;
        foreach ( int numero in listaNumero)
        {

            soma += numero;
        }
        Console.WriteLine($"A soma é: {soma}");

        int quantidadeNumeros = listaNumero.Count;
        float media = (float)soma / quantidadeNumeros;
        Console.WriteLine($"A média é: {media}");
        int maiorNumero = int.MinValue;
        foreach (int numero in listaNumero)
        {
            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }
        Console.WriteLine($"O maior número é: {maiorNumero}");
        Console.WriteLine($"O menor número positovo é: {menorNumero}");
        Console.WriteLine("A lista reordenada é:");
        listaNumero.Sort();
        foreach(int numero in listaNumero)
        {
            Console.WriteLine(numero);
        }


    }
}