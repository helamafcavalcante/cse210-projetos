using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
        "Qual ensinamento de Néfi sobre a árvore da vida mais marcou sua leitura hoje?",
        "Como o exemplo de coragem de Alma e Amuleque em Amoniabe inspira sua vida?",
        "Qual princípio da fé em Cristo o Pai Leí ensinou em seu sonho que você pode aplicar hoje?",
        "De que maneira o relato dos 2.000 jovens guerreiros reflete o poder da fé e da obediência?",
        "Qual versículo do Sermão do Salvador no templo em Terra Fartura tocou mais o seu coração?",
        "Como o testemunho de Morôni nas placas nos fortalece a buscar a verdade pelo Espírito Santo?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random gerador = new Random();
        int indice = gerador.Next(_perguntas.Count);
        return _perguntas[indice];
    }
}