using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Exercicio01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();

            if (triangulo.ValidarTriangulo() == false)
            {
                return false;
            }

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            triangulo.Codigo = codigoAtual;
            codigoAtual = codigoAtual + 1;

            return true;
        }

        public bool Editar(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);

            if (trianguloParaAlterar == null)
            {
                return false;
            }

            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            return true;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }

            return null;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public bool Apagar(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                Triangulo triangulo = triangulos[i];

                if (triangulo.Codigo == codigo)
                {
                    triangulos.Remove(triangulo);

                    return true;
                }
            }

            return false;
        }
    }
}
