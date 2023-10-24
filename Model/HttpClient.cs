
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Model.Repositorio;
public class HttpClientClass{

    private HttpClient httpClientConnection;

    public HttpClient HttpClientConnection{
        get{return httpClientConnection;}
        set{httpClientConnection = value;}
    }

    public HttpClientClass(){
        this.httpClientConnection = new HttpClient();
        this.httpClientConnection.DefaultRequestHeaders.Add("User-Agent", "MeuAplicativo/1.0");
    }
    
    public async Task<List<Repositorio>> GetConnection(){
        string apiGithub = "https://api.github.com/users/AthosGustavo/repos";
        
        try{
            HttpResponseMessage response = await this.httpClientConnection.GetAsync(apiGithub);
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