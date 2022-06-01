using Entra21.ExerciciosOrientacaoObjeto.Exercicio03;
using FluentAssertions;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetoTest.Exercicio03Test
{
    public class ConversorAsciiTest
    {
        public class ConversorTest
        {
            [Theory]
            [InlineData('A', 65)]
            [InlineData('K', 75)]

            public void Validar_Conversor_Ascii(char caracter, int numero)
            {
                //Arrange
                var conversor = new ConversorAscii();
                conversor.Caracter = caracter;                

                //Act
                var result = conversor.ObterCodigoAsciiDoCaracter();

                //Assert
                result.Should().Be(numero);
                //Assert.Equal(numero.ToString(), result.ToString());
            }
        }
    }
}
