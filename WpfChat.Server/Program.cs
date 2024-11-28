using System.Net;
using System.Net.Sockets;

namespace WpfChat.Server;

public class Program
{
    static TcpListener _listener;
    static void Main(string[] args)
    {
        _listener = new TcpListener(IPAddress.Any, 10_000);
        _listener.Start();

        var client = _listener.AcceptTcpClient();
        Console.WriteLine($"Client connected!");
    }
}
