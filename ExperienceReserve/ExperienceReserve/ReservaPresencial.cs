namespace ExperienceReserve;

internal class ReservaPresencial(string nome) : Reserva(nome)
{
    public override void Confirmar()
    {
        Console.WriteLine("Confirmando reserva presencial: " + Nome);
        Console.WriteLine("Ponto de encontro: Praça Central, às 8h");
    }
}
