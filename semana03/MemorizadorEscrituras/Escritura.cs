class Escritura
{
    private readonly Referencia _referencia;
    private readonly List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = texto
            .Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
            .Select(palavra => new Palavra(palavra))
            .ToList();
    }

    public void OcultarPalavrasAleatorias(int quantidade)
    {
        List<int> indicesVisiveis = new();
        for (int i = 0; i < _palavras.Count; i++)
        {
            if (!_palavras[i].EstaOculta())
            {
                indicesVisiveis.Add(i);
            }
        }

        int quantidadeParaOcultar = Math.Min(Math.Max(quantidade, 0), indicesVisiveis.Count);
        for (int i = 0; i < quantidadeParaOcultar; i++)
        {
            int indiceAleatorio = Random.Shared.Next(i, indicesVisiveis.Count);
            (indicesVisiveis[i], indicesVisiveis[indiceAleatorio]) =
                (indicesVisiveis[indiceAleatorio], indicesVisiveis[i]);
            _palavras[indicesVisiveis[i]].Ocultar();
        }
    }

    public bool EstaCompletamenteOculta()
    {
        return _palavras.All(palavra => palavra.EstaOculta());
    }

    public string ObterTexto()
    {
        string texto = string.Join(" ", _palavras.Select(palavra => palavra.ObterTexto()));
        return $"{_referencia.ObterTexto()} {texto}";
    }
}