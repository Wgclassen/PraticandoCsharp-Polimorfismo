namespace Gallery;

internal class Video(string nome, int duracao) : Midia(nome)
{
    public int Duracao { get; set; } = duracao;

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Vídeo: {Nome} - Duração: {Duracao} minutos");
    }
}
