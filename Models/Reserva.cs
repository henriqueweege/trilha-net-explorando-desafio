namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {

                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Capacidade da suíte é menor do que a quantidade de hospedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            decimal discount = 0.10m;
            decimal valor = DiasReservados * Suite.ValorDiaria;
            return DiasReservados < 10 ? valor : valor - (valor * discount);
        }
    }
}