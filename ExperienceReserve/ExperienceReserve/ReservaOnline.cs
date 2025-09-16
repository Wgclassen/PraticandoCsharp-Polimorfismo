namespace ExperienceReserve;

internal class ReservaOnline(string nome) : Reserva(nome)
{
    public override void Confirmar()
    {
        Console.WriteLine("Confirmando reserva online: " + Nome);
        Console.WriteLine("Link de acesso enviado por e-mail!");
    }
}
