using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Exercicio01
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;  
            
            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarMenu();

                Console.Clear();

                if (codigo == 1)
                    ApresentarTriangulos();

                else if (codigo == 2)
                    Cadastrar();

                Console.Write("\n\nAperte alguma tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum Triângulo Cadastrado");
                return;
            }

            Console.WriteLine("Lista de Triângulos");

            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine("Código: " + trianguloAtual.Codigo);
                Console.WriteLine("Lado 1: " + trianguloAtual.Lado1 +
                    "\nLado 2: " + trianguloAtual.Lado2 +
                    "\nLado 3: " + trianguloAtual.Lado3);
            }
        }

        private int ApresentarMenu()
        {
            Console.WriteLine(@"   MENU
1 - LISTAR TODOS OS TRIÂNGULOS CADASTRADOS
2 - CADASTRAR UM TRIÂNGULO
3 - APRESENTAR TRIÂNGULO DETALHADO
4 - EDITAR UM TRIÂNGULO
5 - APAGAR UM TRIÂNGULO
5 - SAIR DA APLICAÇÃO");

            int codigo = SolicitarCodigo();
            return codigo;
        }

        public int SolicitarCodigo()
        {
            var codigo = 0;

            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite um código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um código válido");
                }
            }

            return codigo;
        }

        private void Cadastrar()
        {
            Console.Write("Medida no Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Medida no Lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Medida no Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado1, lado2, lado3);
        }

    }
}
