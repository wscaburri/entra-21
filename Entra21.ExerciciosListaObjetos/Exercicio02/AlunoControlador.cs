﻿namespace Entra21.ExerciciosListaObjetos.Exercicio02
{
    internal class AlunoControlador
    {
        private AlunoServico alunoServico = new AlunoServico();

        public void GerenciarMenu()
        {
            var opcao = 0;

            while (opcao != 13)
            {
                Console.Clear();

                opcao = ApresentarMenu();

                if (opcao == 1)
                    CadastrarAluno();
                else if (opcao == 2)
                    EditarInformacoesAlunos();
                else if (opcao == 3)
                    ApagarRegistroAluno();
                else if (opcao == 4)
                    AlterarNotasAlunos();
                else if (opcao == 5)
                    ListarTodosAlunos();
                else if (opcao == 6)
                    ListarNomesAlunos();
                else if (opcao == 7)
                    ListarAlunosAprovados();
                else if (opcao == 8)
                    ListarAlunosReprovados();
                else if (opcao == 9)
                    ListarAlunosEmExame();
                else if (opcao == 10)
                    ListarMediaAlunoEspecifico();
                else if (opcao == 11)
                    ListarStatusAlunoEspecifico();
                else if (opcao == 12)
                    ListarMediaIdadesAlunos();

                Console.ReadKey();
            }
        }

        private int ApresentarMenu()
        {
            Console.WriteLine(@"---------------MENU---------------
01 - CADASTRAR ALUNO
02 - EDITAR INFORMAÇÕES BÁSICAS DO ALUNO
03 - APAGAR REGISTRO DO ALUNO
04 - ALTERAR AS NOTAS DO ALUNO
05 - LISTAR TODOS OS ALUNOS
06 - LISTAR TODOS OS NOMES DOS ALUNOS
07 - LISTAR O NOME DOS ALUNOS APROVADOS
08 - LISTAR O NOME DOS ALUNOS REPROVADOS
09 - LISTAR O NOME DOS ALUNOS EM EXAME
10 - VISUALIZAR MÉDIA DE UM ALUNO
11 - VISUALIZAR STATUS DE UM ALUNO
12 - VISUALIZAR A MÉDIA DE IDADES DOS ALUNOS
13 - SAIR");

            var codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            var codigo = 0;

            while (codigo < 1 || codigo > 13)
            {
                try
                {
                    Console.Write("Digite a opção desejada: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            }

            return codigo;
        }

        private void CadastrarAluno()
        {
            Console.Write("Informe o nome do Aluno: ");
            var aluno = Console.ReadLine();

            Console.Write("Informe a idade do Aluno: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a matéria favorita do Aluno: ");
            var materiaFavorita = Console.ReadLine();

            Console.Write("Informe a Nota 01 do Aluno: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a Nota 02 do Aluno: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a Nota 03 do Aluno: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            alunoServico.AdicionarAluno(aluno, idade, materiaFavorita, nota1, nota2, nota3);
        }

        private void ListarTodosAlunos()
        {
            var alunos = alunoServico.ObterTodosAlunos();

            if (alunos == null)
            {
                Console.WriteLine("Nenhum aluno encontrado");
                return;
            }

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                Console.WriteLine("Código Matrícula: " + alunoAtual.CodigoMatricula +
                    "\nAluno: " + alunoAtual.Nome);
                Console.WriteLine();
            }
        }

        private void EditarInformacoesAlunos()
        {
            ListarTodosAlunos();

            Console.Write("Digite o código de matrícula do Aluno: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome do Aluno: ");
            var nome = Console.ReadLine();

            Console.Write("Informe a idade do Aluno: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a matéria favorita do Aluno: ");
            var materiaFavorita = Console.ReadLine();

            var alunoEditado = alunoServico.EditarDadosCadastrais(nome, idade, codigoMatricula, materiaFavorita);

            Console.Write(alunoEditado == true
                ? "Aluno editado com sucesso."
                : "Não foi possível editar o aluno.");
        }

        private void ApagarRegistroAluno()
        {
            ListarTodosAlunos();

            Console.Write("Informe o nome do aluno que será apagado: ");
            var nomeAluno = Console.ReadLine().ToLower().Trim();

            var excluirAluno = alunoServico.RemoverAluno(nomeAluno);

            Console.Write(excluirAluno == true
                ? "Aluno removido com sucesso"
                : "Nenhum aluno cadastrado");
        }

        private void AlterarNotasAlunos()
        {
            ListarTodosAlunos();

            Console.Write("Digite o código de matrícula do aluno: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a Nota 01 do Aluno: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a Nota 02 do Aluno: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a Nota 03 do Aluno: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            var alterarNotas = alunoServico.EditarNotasAluno(codigoMatricula, nota1, nota2, nota3);

            Console.Write(alterarNotas == true
                ? "Notas alteradas com sucesso"
                : "Não foi possível alterar as notas");
        }

        private void ListarNomesAlunos()
        {
            var nomes = "";
            var alunos = alunoServico.ObterNomes();

            for (int i = 0; i < alunos.Count; i++)
            {
                nomes += alunos[i] + "\n";
            }

            Console.WriteLine("Nome de todos os alunos: " +
                "\n" + nomes);
        }

        private void ListarAlunosAprovados()
        {
            var nomes = "";
            var alunos = alunoServico.ObterAprovados();

            for (int i = 0; i < alunos.Count; i++)
            {
                nomes += alunos[i] + "\n";
            }

            Console.WriteLine("Nome dos alunos Aprovados: " +
                "\n" + nomes);
        }

        private void ListarAlunosReprovados()
        {
            var nomes = "";
            var alunos = alunoServico.ObterReprovados();

            for (int i = 0; i < alunos.Count; i++)
            {
                nomes += alunos[i] + "\n";
            }

            Console.WriteLine("Nome dos alunos Reprovados: " +
                "\n" + nomes);
        }

        private void ListarAlunosEmExame()
        {
            var nomes = "";
            var alunos = alunoServico.ObterEmExame();

            for (int i = 0; i < alunos.Count; i++)
            {
                nomes += alunos[i] + "\n";
            }

            Console.WriteLine("Nome dos alunos Em Exame: " +
                "\n" + nomes);
        }

        private void ListarMediaAlunoEspecifico()
        {
            ListarTodosAlunos();

            Console.Write("Digite o Código de Matrícula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            var mediaAluno = alunoServico.ObterMediaPorCodigoMatricula(codigoMatricula);

            Console.WriteLine("A média do aluno é: " + mediaAluno.ToString());
        }

        private void ListarStatusAlunoEspecifico()
        {
            ListarTodosAlunos();

            Console.Write("Digite o Código de Matrícula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            var statusAluno = alunoServico.ObterStatusPorCodigoMatricula(codigoMatricula);

            Console.WriteLine("O status do aluno é: " + statusAluno);
        }

        private void ListarMediaIdadesAlunos()
        {
            Console.WriteLine("A média das idades dos alunos é de: " + alunoServico.ObterMediaIdades().ToString() + " anos");
        }
    }
}