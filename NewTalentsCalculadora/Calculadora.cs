namespace NewTalentsCalculadora;

public class Calculadora
{
    private List<string> _listaHistorico;
    private string _data;

    public Calculadora(string data)
    {
        _listaHistorico = new List<string>();
        _data = data;
    }

    public int Somar(int num1, int num2)
    {
        var res = num1 + num2;
        _listaHistorico.Insert(0, $"{_data}:: {num1} + {num2} = {res}");

        return res;
    }

    public int Subtrair(int num1, int num2)
    {
        var res = num1 - num2;
        _listaHistorico.Insert(0, $"{_data}:: {num1} - {num2} = {res}");

        return res;
    }

    public int Multiplicar(int num1, int num2)
    {
        var res = num1 * num2;
        _listaHistorico.Insert(0, $"{_data}:: {num1} * {num2} = {res}");

        return res;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 == 0) throw new DivideByZeroException();
        var res = num1 / num2;
        _listaHistorico.Insert(0, $"{_data}:: {num1} / {num2} = {res}");

        return res;
    }

    public List<string> Historico()
    {
        _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
        return _listaHistorico;
    }
}