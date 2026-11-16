class Referencia
{
    private readonly string _livro;
    private readonly int _capitulo;
    private readonly int _versiculo;
    private readonly int _ultimoVersiculo;

    public Referencia(string livro, int capitulo, int versiculo)
        : this(livro, capitulo, versiculo, versiculo)
    {
    }

    public Referencia(string livro, int capitulo, int versiculoInicial, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculoInicial;
        _ultimoVersiculo = versiculoFinal;
    }

    public string ObterTexto()
    {
        string versiculos = _versiculo == _ultimoVersiculo
            ? _versiculo.ToString()
            : $"{_versiculo}-{_ultimoVersiculo}";

        return $"{_livro} {_capitulo}:{versiculos}";
    }
}