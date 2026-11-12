using System;

public class Emprego
{
    public string _empresa = "";
    public string _cargo = "";
    public int _anoInicio = 0;
    public int _anoFim = 0;

    public void Exibir()
    {
        Console.WriteLine($"{_cargo} ({_empresa}) {_anoInicio}-{_anoFim}");
    }
}