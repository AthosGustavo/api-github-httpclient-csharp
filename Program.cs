// See https://aka.ms/new-console-template for more information

using api_github.Controller;
using Model.Repositorio;

class Program{

    public static async Task Main(string[] args)
    {
        HttpClientController application = new HttpClientController();
        await application.GetRepositorios();

    }
}
