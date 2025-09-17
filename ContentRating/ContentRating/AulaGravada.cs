namespace ContentRating;
internal class AulaGravada(string titulo, int duracao) : Conteudo(titulo)
{
    public int Duracao { get; set; } = duracao;
    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine("Duração: " + Duracao);
    }
}
