using NewTalentsCalculadora;

namespace NewTalentsCalculadoraTestes;

public class CalculadoraTests
{
    private Calculadora _calc;

    public CalculadoraTests()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    public void SomeDoisNumerosERetorneOResultado(int num1, int num2, int res)
    {
        //Arrange

        //Act
        var resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(2, 3, -1)]
    public void SubtraiaDoisNumerosERetorneOResultado(int num1, int num2, int res)
    {
        //Arrange

        //Act
        var resultado = _calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 6)]
    public void MultipliqueDoisNumerosERetorneOResultado(int num1, int num2, int res)
    {
        //Arrange

        //Act
        var resultado = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(6, 3, 2)]
    public void DividaDoisNumerosERetorneOResultado(int num1, int num2, int res)
    {
        //Arrange

        //Act
        var resultado = _calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(res, resultado);
    }

    [Fact]
    public void DividaPorZeroRetorneErro()
    {
        //Arrange
        int num1 = 3;
        int num2 = 0;

        //Act

        //Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(num1, num2));
    }

    [Fact]
    public void VerifiqueOHistoricoERetorneQuantidadeItens()
    {
        //Arrange

        //Act
        _calc.Somar(1, 2);
        _calc.Somar(2, 3);
        _calc.Somar(4, 5);
        _calc.Somar(6, 7);

        var lista = _calc.Historico();

        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}