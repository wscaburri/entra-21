using Entra21.ExerciciosOrientacaoObjeto.Exercicio03;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        public UnitTest1()
        {

        }

        [Theory]
        [InlineData(65)]

        public void Validar_Conversor_Ascii(char caracter)
        {
            //Arrange
            var conversor = new ConversorAscii();
            conversor.Caracter = Caracter;
        }

    }
}