using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetoTest.Exercicio03Test
{
    public class ConversorTest
    {
        [Theory]
        [InlineData(A)]

        public void Validar_Conversor_Ascii(Caracter)
        {
            //Arrange
            var conversor = new ConversorTest();
            conversor.Caracter = Caracter;
        }

    }
}
