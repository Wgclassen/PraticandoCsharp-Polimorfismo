namespace Gallery;

internal class Midia(string nome)
{
    public string Nome { get; set; } = nome;
    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Midia: {Nome}");
    }
}
