using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioBancoDadosCidades.Models
{
    public class Cidade
    {
        public int Id { get; set; }

        public UnidadeFederativa UnidadeFederativa { get; set; }

        public string Nome { get; set; }

        public int QuandidadeHabitantes { get; set; }

        public DateTime DataHoraFundacao { get; set; }

        public double Pib { get; set; }
    }
}
