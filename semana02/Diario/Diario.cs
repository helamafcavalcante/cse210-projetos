using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string nomeArquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(nomeArquivo))
        {
            arquivoSaida.WriteLine("Data,Pergunta,Resposta");

            foreach (Registro registro in _registros)
            {
                string dataTratada = $"\"{registro._data.Replace("\"", "\"\"")}\"";
                string perguntaTratada = $"\"{registro._textoPergunta.Replace("\"", "\"\"")}\"";
                string respostaTratada = $"\"{registro._textoResposta.Replace("\"", "\"\"")}\"";

                arquivoSaida.WriteLine($"{dataTratada},{perguntaTratada},{respostaTratada}");
            }
        }
    }

    public void CarregarDoArquivo(string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            _registros.Clear();

            for (int i = 1; i < linhas.Length; i++)
            {
                string linha = linhas[i];
                string[] partes = SepararLinhaCsv(linha);

                if (partes.Length >= 3)
                {
                    Registro registro = new Registro();
                    registro._data = partes[0];
                    registro._textoPergunta = partes[1];
                    registro._textoResposta = partes[2];
                    _registros.Add(registro);
                }
            }
        }
    }

    private string[] SepararLinhaCsv(string linha)
    {
        List<string> partes = new List<string>();
        bool dentroDeAspas = false;
        string valorAtual = "";

        for (int i = 0; i < linha.Length; i++)
        {
            char c = linha[i];

            if (c == '"')
            {
                if (dentroDeAspas && i + 1 < linha.Length && linha[i + 1] == '"')
                {
                    valorAtual += '"';
                    i++;
                }
                else
                {
                    dentroDeAspas = !dentroDeAspas;
                }
            }
            else if (c == ',' && !dentroDeAspas)
            {
                partes.Add(valorAtual);
                valorAtual = "";
            }
            else
            {
                valorAtual += c;
            }
        }
        partes.Add(valorAtual);
        return partes.ToArray();
    }
}