using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio03
{
    public class ExemploConversorAscii
    {
        public void Executar()
        {
            ConversorAscii conversor = new ConversorAscii();

            Console.Write("Informe o caracter: ");
            conversor.Caracter = Convert.ToChar(Console.ReadLine());

            var mostrarCodigo = conversor.ObterCodigoAsciiDoCaracter();

            Console.WriteLine("Código Ascii: " + mostrarCodigo); 
        }
    }
}
