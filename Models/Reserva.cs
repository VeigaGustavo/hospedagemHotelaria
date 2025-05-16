namespace hospedagemHotelaria.Models;

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
        if (Suite != null && Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new InvalidOperationException("A quantidade de hóspedes é maior que a capacidade da suíte.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes != null ? Hospedes.Count : 0;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * (Suite != null ? Suite.ValorDiaria : 0);

        if (DiasReservados >= 10)
        {
            valor *= 0.9m;
        }

        return valor;
    }
}