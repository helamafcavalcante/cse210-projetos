using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio2.");
        Console.Write("Qual a nota do aluno de 0 a 100? ");
        string notaDigitada = Console.ReadLine();
        int nota = int.Parse(notaDigitada);
        string letraNota = "";

        if (nota >= 90)
        {
            if (nota >= 93)
            {
                letraNota = "A";
            }
            else
            {
                letraNota = "A-";               
            }    
        }
        else if (nota >= 80 && nota <=89)
        {
            if (nota >= 87)
            {
                letraNota = "B+";
            }
            else if (nota >= 83 && nota < 87)
            {
                letraNota = "D";               
            }
            else
            {
                letraNota = "D-";
            }

        }
        else if (nota >= 70 && nota <=79)
        {
            if (nota >= 77)
            {
                letraNota = "C+";
            }
            else if (nota >= 73 && nota < 77)
            {
                letraNota = "C";               
            }
            else
            {
                letraNota = "C-";
            }
        }
        else if (nota >= 60 && nota <=69)
        {
            if (nota >= 67)
            {
                letraNota = "D+";
            }
            else if (nota >= 63 && nota < 67)
            {
                letraNota = "D";               
            }
            else
            {
                letraNota = "D-";
            }
        }
        else
        {
            letraNota = "F";
        }
        
        Console.WriteLine($"Sua nota é: {letraNota}");
        
        if (nota >= 70)
        {
            Console.WriteLine("Você passou!");
        }
        else
        {
            Console.WriteLine("Mais sorte da próxima vez!");
        }

    }
}