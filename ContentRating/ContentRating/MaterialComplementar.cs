namespace ContentRating;

internal class MaterialComplementar(string titulo, int paginas) : Conteudo(titulo)
{
    public int Paginas { get; set; } = paginas;
    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine("Páginas: " + Paginas);
    }
}