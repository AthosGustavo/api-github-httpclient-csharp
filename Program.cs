// See https://aka.ms/new-console-template for more information

class Program{

    public static async Task Main(string[] args){
        Console.WriteLine("Olá, digite o seu user no github sem a presença do '@', Exemplo:AthosGustavo");
        string resposta = Console.ReadLine();
        Console.WriteLine(resposta);

        HttpClientClass teste = new HttpClientClass();
    }
}
