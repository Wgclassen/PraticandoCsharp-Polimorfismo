using SchedulledTask;

List<TarefaAgendada> tarefas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new RelatorioTarefa(),
    new LimpezaTarefa()
};

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}