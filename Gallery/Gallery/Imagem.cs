namespace Gallery;

internal class Imagem(string nome, string resolucao) : Midia(nome)
{
    public string Resolucao { get; set; } = resolucao;
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
    }
}
