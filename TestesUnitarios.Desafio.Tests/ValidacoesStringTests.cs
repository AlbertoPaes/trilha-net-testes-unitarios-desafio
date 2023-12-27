using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

[Trait("String", "ValidacoesString")]
public class ValidacoesStringTests : Tests
{
    private readonly string StringDeExemplo = "Esse é um texto qualquer";

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoesString.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterUmaPalavraQualquerNoTexto()
    {
        // Arrange
        var textoProcurado = "qualquer";

        // Act
         var resultado = _validacoesString.ContemCaractere(StringDeExemplo, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoesString.ContemCaractere(StringDeExemplo, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoesString.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
