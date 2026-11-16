public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavrasTexto = texto.Split(' ');

        foreach (string palavra in palavrasTexto)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void OcultarPalavrasAleatorias(int quantidade)
    {
        List<int> indicesVisiveis = new List<int>();
        for (int i = 0; i < _palavras.Count; i++)
        {
            if (!_palavras[i].EstaOculta())
            {
                indicesVisiveis.Add(i);
            }
        }

        Random random = new Random();
        int quantidadeParaOcultar = quantidade;
        if (quantidadeParaOcultar < 0)
        {
            quantidadeParaOcultar = 0;
        }

        if (quantidadeParaOcultar > indicesVisiveis.Count)
        {
            quantidadeParaOcultar = indicesVisiveis.Count;
        }

        for (int i = 0; i < quantidadeParaOcultar; i++)
        {
            int posicaoAleatoria = random.Next(indicesVisiveis.Count);
            int indicePalavra = indicesVisiveis[posicaoAleatoria];
            _palavras[indicePalavra].Ocultar();
            indicesVisiveis.RemoveAt(posicaoAleatoria);
        }
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }

    public string ObterTexto()
    {
        string texto = "";

        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterTexto() + " ";
        }

        return $"{_referencia.ObterTexto()} {texto}";
    }
}