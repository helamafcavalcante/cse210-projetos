public class Referencias
{
    private readonly string _livro;
    private readonly int _capitulo;
    private readonly int _versiculoInicial;
    private readonly int _versiculoFinal;

    public Referencias(string livro, int capitulo, int versiculo)
        : this(livro, capitulo, versiculo, versiculo)
    {
    }

    public Referencias(string livro, int capitulo, int versiculoInicial, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculoInicial;
        _versiculoFinal = versiculoFinal;
    }

    public string ObterTextoExibido()
    {
        string versiculos = _versiculoInicial == _versiculoFinal
            ? _versiculoInicial.ToString()
            : $"{_versiculoInicial}-{_versiculoFinal}";

        return $"{_livro} {_capitulo}:{versiculos}";
    }
}