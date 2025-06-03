using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuevaraGExamenProg2.Repositories
{
    internal class ChistesRepository
    {
        private readonly HttpClient _httpClient;
        public ChistesRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> ObtenerChistesAsync()
        {
            //obtener respuesta api
            var response = await _httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");   
            //abrir paquete json
            var json = JObject.Parse(response);
            //obtener variables
            string setup = json["setup"]?.ToString();
            string punchline = json["punchline"]?.ToString();
            
            return $"{setup}\n\n{punchline}";
        }

    }

}
