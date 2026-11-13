// Para ir além dos requisitos básicos e demonstrar criatividade, 
// aprimorei o processo de salvamento e carregamento para utilizar o formato 
// de arquivo .csv com colunas bem definidas (Data, Pergunta, Resposta), 
// tratando corretamente vírgulas e aspas para que possa ser aberto e 
// manipulado diretamente no Excel.

using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas geradorPerguntas = new GeradorDePerguntas();
        int escolha = 0;

        while (escolha != 5)
        {
            Console.WriteLine("Menu do Diário:");
            Console.WriteLine("1. Escrever novo registro");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Salvar diário em um arquivo CSV");
            Console.WriteLine("4. Carregar diário de um arquivo CSV");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            
            string input = Console.ReadLine();
            if (int.TryParse(input, out escolha))
            {
                if (escolha == 1)
                {
                    string pergunta = geradorPerguntas.ObterPerguntaAleatoria();
                    Console.WriteLine(pergunta);
                    Console.Write("> ");
                    string resposta = Console.ReadLine();

                    Registro novoRegistro = new Registro();
                    novoRegistro._data = DateTime.Now.ToShortDateString();
                    novoRegistro._textoPergunta = pergunta;
                    novoRegistro._textoResposta = resposta;

                    diario.AdicionarRegistro(novoRegistro);
                }
                else if (escolha == 2)
                {
                    diario.ExibirTodos();
                }
                else if (escolha == 3)
                {
                    Console.Write("Digite o nome do arquivo CSV para salvar (ex: diario.csv): ");
                    string arquivo = Console.ReadLine();
                    diario.SalvarNoArquivo(arquivo);
                }
                else if (escolha == 4)
                {
                    Console.Write("Digite o nome do arquivo CSV para carregar: ");
                    string arquivo = Console.ReadLine();
                    diario.CarregarDoArquivo(arquivo);
                }
            }
            Console.WriteLine();
        }
    }
}