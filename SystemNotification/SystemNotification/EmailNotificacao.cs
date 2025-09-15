namespace SystemNotification;

internal class EmailNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine("Enviando E-MAIL: " + mensagem);
    }
}
