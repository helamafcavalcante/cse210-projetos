using System;

class Program
{
    static void Main(string[] args)
    {
        
        string continuarJogando = "sim";
        while (continuarJogando == "sim")
        {
            Random geradorNumero = new Random();
            int numeroAleatorio = geradorNumero.Next(1, 101); 
            int numeroTentativas = 0;
            int palpite = -1;            
            while (palpite != numeroAleatorio)
            {
                numeroTentativas +=1;
                Console.Write("Olá qual o seu palpite? "); 
                palpite = int.Parse(Console.ReadLine());                
                if (numeroAleatorio > palpite)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (numeroAleatorio < palpite)
                {
                    Console.WriteLine("Mais baixo");
                }
                else
                {
                    Console.WriteLine("Você acertou o número");
                    Console.WriteLine($"Você precisou de {numeroTentativas} tentativas! ");
                }
            }
            Console.Write("Você quer continuar Jogando? ");
            continuarJogando = Console.ReadLine();
        }
    }
}