namespace Entra21.ExerciciosListaObjetos.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();

        private int codigoMatriculaAluno = 1;

        public void AdicionarAluno(string nome, int idade, string materiaFavorita,
            double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            aluno.CodigoMatricula = codigoMatriculaAluno;
            codigoMatriculaAluno++;

            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.Nome == nome)
                {
                    alunos.Remove(alunoAtual);
                    return true;
                }
            }

            return false;
        }

        public Aluno ObterPorCodigoMatricula(int codigoMatricula)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.CodigoMatricula == codigoMatricula)
                    return alunoAtual;
            }

            return null;
        }

        public bool EditarDadosCadastrais(string nome, int idade, int codigoMatricula, string materiaFavorita)
        {
            var alunoParaEditar = ObterPorCodigoMatricula(codigoMatricula);

            if (alunoParaEditar == null)
                return false;

            alunoParaEditar.Nome = nome;
            alunoParaEditar.Idade = idade;
            alunoParaEditar.MateriaFavorita = materiaFavorita;

            return true;
        }

        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            var alunoEditarNotas = ObterPorCodigoMatricula(codigoMatricula);

            if (alunoEditarNotas == null)
                return false;

            alunoEditarNotas.Nota1 = nota1;
            alunoEditarNotas.Nota2 = nota2;
            alunoEditarNotas.Nota3 = nota3;

            return true;
        }

        public List<string> ObterNomes()
        {
            List<string> nomes = new List<string>();

            if (alunos == null)
                return null;

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                nomes.Add(alunoAtual.Nome);
            }

            return nomes;
        }

        public List<double> ObterMedias()
        {
            List<double> notas = new List<double>();

            if (alunos == null)
                return null;

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];
                notas.Add(alunoAtual.CalcularMedia());
            }

            return notas;
        }

        public List<string> ObterAprovados()
        {
            List<string> alunosAprovados = new List<string>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.ObterStatus() == AlunoStatus.Aprovado)
                    alunosAprovados.Add(alunoAtual.Nome);
            }

            return alunosAprovados;
        }

        public List<string> ObterReprovados()
        {
            List<string> alunosReprovados = new List<string>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.ObterStatus() == AlunoStatus.Reprovado)
                    alunosReprovados.Add(alunoAtual.Nome);
            }

            return alunosReprovados;
        }

        public List<string> ObterEmExame()
        {
            List<string> alunosEmExame = new List<string>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.ObterStatus() == AlunoStatus.EmExame)
                    alunosEmExame.Add(alunoAtual.Nome);
            }

            return alunosEmExame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            var alunoAtual = ObterPorCodigoMatricula(codigoMatricula);

            return alunoAtual.CalcularMedia();
        }

        public AlunoStatus ObterStatusPorCodigoMatricula(int codigoMatricula)
        {
            var alunoAtual = ObterPorCodigoMatricula(codigoMatricula);

            return alunoAtual.ObterStatus();
        }

        public double ObterMediaIdades()
        {
            var somaIdadesAlunos = 0.0;

            for (int i = 0; i < alunos.Count; i++)
            {
                somaIdadesAlunos += alunos[i].Idade;
            }

            var mediaIdadesAlunos = somaIdadesAlunos / alunos.Count;

            return mediaIdadesAlunos;
        }

        public List<Aluno> ObterTodosAlunos()
        {
            return alunos;
        }
    }
}