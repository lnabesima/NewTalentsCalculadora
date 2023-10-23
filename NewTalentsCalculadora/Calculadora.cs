namespace NewTalentsCalculadora;

public class Calculadora
{
    private List<string> _listaHistorico;

    public Calculadora()
    {
        _listaHistorico = new List<string>();
    }

    public int Somar(int num1, int num2)
    {
        var res = num1 + num2;
        _listaHistorico.Insert(0, $"{num1} + {num2} = {res}");

        return res;
    }

    public int Subtrair(int num1, int num2)
    {
        var res = num1 - num2;
        _listaHistorico.Insert(0, $"{num1} - {num2} = {res}");

        return res;
    }

    public int Multiplicar(int num1, int num2)
    {
        var res = num1 * num2;
        _listaHistorico.Insert(0, $"{num1} * {num2} = {res}");

        return res;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 == 0) throw new DivideByZeroException();
        var res = num1 / num2;
        _listaHistorico.Insert(0, $"{num1} / {num2} = {res}");

        return res;
    }

    public List<string> Historico()
    {
        _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
        return _listaHistorico;
    }
}