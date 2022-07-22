namespace Entra21.ExercicioBancoDadosCidades.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuandidadeHabitantes { get; set; }
        public double Pib { get; set; }
        public DateTime DataHoraFundacao { get; set; }

        public UnidadeFederativa UnidadeFederativa { get; set; }
    }
}