using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

[Trait ("Lista", "ValidacoesLista")]
public class ValidacoesListaTests : Tests
{
    private readonly List<int> ListaDeExemplo = new List<int> { 5, -1, -8, 9 };

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoesLista.RemoverNumerosNegativos(ListaDeExemplo);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoesLista.ListaContemDeterminadoNumero(ListaDeExemplo, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoesLista.ListaContemDeterminadoNumero(ListaDeExemplo, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var numeroParaMultiplicar = 2;
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado = _validacoesLista.MultiplicarNumerosLista(lista, numeroParaMultiplicar);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var numeroParaSerOMaior = 9;

        // Act
        var resultado = _validacoesLista.RetornarMaiorNumeroLista(ListaDeExemplo);

        // Asser
        Assert.Equal(numeroParaSerOMaior, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var numeroParaSerOMenor = -8;

        // Act
        var resultado = _validacoesLista.RetornarMenorNumeroLista(ListaDeExemplo);

        // Assert
        Assert.Equal(numeroParaSerOMenor, resultado);
    }
}
