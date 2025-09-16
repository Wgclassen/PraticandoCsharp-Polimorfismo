namespace ExperienceReserve;

internal abstract class Reserva(string nome)
{
    public string Nome { get; } = nome;
    public virtual void Confirmar()
    {
        Console.WriteLine("Confirmando reserva genérica: " + Nome);
    }
}
