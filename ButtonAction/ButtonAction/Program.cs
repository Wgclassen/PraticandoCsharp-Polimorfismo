using ButtonAction;

List<IAcaoBotao> acoes = new List<IAcaoBotao>
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};

foreach (var acao in acoes)
{
    acao.Executar();
}