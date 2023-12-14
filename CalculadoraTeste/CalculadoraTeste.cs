namespace CalculadoraTeste;

public class CalculadoraTeste
{
    private CalculadoraImpementada _resultadoSoma;
    private NumerosPar _numeroPar;
    //Construtor da CalculadoraTest
    public CalculadoraTeste()
    {
        _numeroPar = new NumerosPar();
        _resultadoSoma = new CalculadoraImpementada();
    }


    //Metodo onde ira realizar os testes da soma
    [Fact]
    public void DeveRealizarAsomaEntreDoisNumeros()
    {
        // Arange
        int numeroOne = 10;
        int numerotwo = 89;
        int resultadoEsperado = numeroOne + numerotwo;

        // Fact
        int resultadoSomaCalculadora = _resultadoSoma.Somar(numeroOne, numerotwo);

        // Assert -> temos que passar 2 parametros - 1° o resultado esperado , 
        // 2° o resultado da soma que fica na class onde estamos testando
        Assert.Equal(resultadoEsperado, resultadoSomaCalculadora);
    }

    [Theory]
    [InlineData(24)]
    [InlineData(20)]
    [InlineData(22)]
    [InlineData(16)]
    [InlineData(14)]
    [InlineData(12)]
    [InlineData(10)]
    [InlineData(17)]
    public void DeveRetornarSeOsNumerosEpar(int numero)
    {
        //Quando usamos a notação [Theory] -> não precisamos do Arrange

        // Act
        bool verificarNumerosPar = _numeroPar.RetornarPar(numero);

        // Assert
        Assert.True(verificarNumerosPar);
    }
}