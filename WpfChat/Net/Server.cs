﻿using System.Net.Sockets;

namespace WpfChat.Client.Net;
public class Server
{
    TcpClient _client;
    public Server()
    {
        _client = new TcpClient();
    }

    public void ConnectToServer()
    {
        if (!_client.Connected)
        {
            _client.Connect("127.0.0.1", 10_000);
        }
    }
}
