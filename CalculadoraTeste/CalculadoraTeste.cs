namespace CalculadoraTeste;

public class CalculadoraTeste
{
    private CalculadoraImpementada _resultadoSoma;

    //Construtor da CalculadoraTest
    public CalculadoraTeste()
    {
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

        // Assert -> temos que passar 2 parametros - 1° o resultado esperado , 2° o resultado da soma que fica na class onde estamos testando
        Assert.Equal(resultadoEsperado, resultadoSomaCalculadora);

    }
}