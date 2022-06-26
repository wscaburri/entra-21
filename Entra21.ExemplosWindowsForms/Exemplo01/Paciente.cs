namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class Paciente
    {
        public int Codigo;
        public string Nome;
        public double Altura;
        public double Peso;

        public double ObterImc()
        {
            return Peso / Math.Pow(Altura, 2);
        }
    }
}