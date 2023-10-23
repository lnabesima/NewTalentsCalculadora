namespace NewTalentsCalculadora;

public class Calculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 == 0) throw new DivideByZeroException();
        return num1 / num2;
    }

    public List<string> Historico()
    {
        return new List<string>();
    }
}