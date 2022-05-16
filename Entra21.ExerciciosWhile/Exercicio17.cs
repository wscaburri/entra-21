namespace Entra21.ExerciciosWhile
{
    internal class Exercicio17
    {
        public void Executar()
        {
            //17. Faça um temporizador começando com 23:59:59 até 00:00:00.

            int hora = 23, minuto = 59, segundo = 59;

            while (hora >= 0 && minuto >= 0 && segundo >= 0)
            {
                segundo = segundo - 1;
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto = minuto - 1;
                    if (minuto < 0)
                    {
                        minuto = 59;
                        hora = hora - 1;
                    }
                }

                Console.WriteLine(hora + ":" + minuto + ":" + segundo);
            }
        }
    }
}
