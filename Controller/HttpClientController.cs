using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using Newtonsoft.Json;
using Model.Repositorio;

namespace api_github.Controller
{
    public class HttpClientController{

        private List<Repositorio> list;

        
        public async Task GetRepositorios(){
            Console.Write("Digite o seu usuário no github sem a presença do '@',Ex:AthosGustavo ->");
            string responseNameUser = Console.ReadLine();
            HttpClientClass httpObject = new HttpClientClass(responseNameUser);
            this.list = await httpObject.GetConnection();

            for(int i = 0;i < list.Count;i++){
                Console.WriteLine(list[i]);
            } 
            
        }

        
    }
}