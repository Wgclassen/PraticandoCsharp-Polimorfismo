﻿namespace SystemNotification;

internal class PushNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine("Enviando PUSH: " + mensagem);
    }
}