using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();

        //private int codigoMatricula = 1;

        public void AdicionarAluno(string nome, int idade, int codigoMatricula, string materiaFavorita,
            double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;            
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];

                if (aluno.Nome == nome)
                {
                    alunos.Remove(aluno);
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
                {
                    return alunoAtual;
                }
            }

            return null;
        }

        public bool EditarDadosCadastrais(string nome, int idade, int codigoMatricula, string materiaFavorita)
        {
            Aluno alunoParaEditar = ObterPorCodigoMatricula(codigoMatricula);

            if (alunoParaEditar == null)
                return false;

            alunoParaEditar.Nome = nome;
            alunoParaEditar.Idade = idade;
            alunoParaEditar.MateriaFavorita = materiaFavorita;            

            return true;
        }

        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno notasParaEditar = ObterPorCodigoMatricula(codigoMatricula);

            if (notasParaEditar == null)
                return false;

            notasParaEditar.Nota1 = nota1;
            notasParaEditar.Nota2 = nota2;
            notasParaEditar.Nota3 = nota3;

            return true;
        }

        public List<string> ObterNomes()
        {
            var nomes = new List<string>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];
            }
            return nomes;
        }

        public List<double> ObterMedias()
        {
            var mediaAluno = new List<double>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];
                mediaAluno.Add(aluno.CalcularMedia());                
            }

            return mediaAluno;            
        }
        
    }
}
