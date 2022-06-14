namespace Entra21.ExerciciosListaObjetos.Exercicio02
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        double media;

        public double CalcularMedia()
        {
            media = (Nota1 + Nota2 + Nota3) / 3;

            return media;
        }

        public AlunoStatus ObterStatus()
        {
            if (media < 5)
                return AlunoStatus.Reprovado;
            else if (media < 7)
                return AlunoStatus.EmExame;
            else
                return AlunoStatus.Aprovado;
        }

    }
}
