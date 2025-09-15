namespace SystemNotification;

internal class SmsNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine("Enviando SMS: " + mensagem);
    }
}
