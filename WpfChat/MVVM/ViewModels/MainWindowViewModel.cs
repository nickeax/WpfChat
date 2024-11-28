using WpfChat.Client.MVVM.Core;
using WpfChat.Client.Net;

namespace WpfChatClient.MVVM.ViewModels;
public class MainWindowViewModel
{
    public RelayCommand ConnectToServerCommand { get; set; }
    Server _server;

    public MainWindowViewModel()
    {
        _server = new Server();
        ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer());
    }
}
