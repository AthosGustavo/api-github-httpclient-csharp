// See https://aka.ms/new-console-template for more information

using api_github.Controller;
using Model.Repositorio;

class Program{

    public static async Task Main(string[] args)
    {
        // HttpClientClass teste = new HttpClientClass("AthosGustavo");
        // List<Repositorio> repositorios = await teste.GetConnection();
        
        // // for(int i = 0; i < repositorios.Count; i++){
        // //     Console.WriteLine(repositorios[i]);
        // // }
        // Console.WriteLine(repositorios[0]);

        HttpClientController application = new HttpClientController();
        await application.GetRepositorios();

    }
}
