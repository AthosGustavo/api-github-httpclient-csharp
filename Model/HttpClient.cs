
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Model.Repositorio;
public class HttpClientClass{

    private HttpClient httpClientConnection;
    private string apiGithub;
    public string ApiGithub{
        get{return apiGithub;}
        set{apiGithub = value;}
    }

    public HttpClient HttpClientConnection{
        get{return httpClientConnection;}
        set{httpClientConnection = value;}
    }

    public HttpClientClass(){
        this.httpClientConnection = new HttpClient();
        this.apiGithub = $"https://api.github.com/users/AthosGustavo/repos";
        this.httpClientConnection.DefaultRequestHeaders.Add("User-Agent", "MeuAplicativo/1.0");
    }

    // public void nameUser(){
    //     Console.Write("Digite o seu usuário no github sem a presença do '@',Ex:AthosGustavo ->");
    //     string responseNameUser = Console.ReadLine();
    //     this.apiGithub = $"https://api.github.com/users/{responseNameUser}/repos";

    // }
    
    public async Task<List<Repositorio>> GetConnection(){
        
        
        //string apiGithub = "https://api.github.com/users/AthosGustavo/repos";
        
        try{
            HttpResponseMessage response = await this.httpClientConnection.GetAsync(this.apiGithub);
            string responseString = await response.Content.ReadAsStringAsync();
            //JArray responseArray = JArray.Parse(responseString);
            List<Repositorio> repositorios = JsonConvert.DeserializeObject<List<Repositorio>>(responseString);

            response.EnsureSuccessStatusCode();
            HttpStatusCode statusCode = response.StatusCode;
            
            if(response.IsSuccessStatusCode){
                Console.WriteLine($"Status da requisição: {statusCode}");
            }else{
                Console.WriteLine($"Status da requisição: {statusCode}");
            }
            return repositorios;

        }catch(HttpRequestException exception){
            Console.WriteLine($"Exceção inesperada: {exception.Message}");
            return null;
        }finally{
            this.httpClientConnection.Dispose();
            
            
        }

       
        
    }

}