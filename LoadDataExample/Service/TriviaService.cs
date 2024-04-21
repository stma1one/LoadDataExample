using LoadDataExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoadDataExample.Service
{
    public class TriviaService
    {
        private HttpClient client;
        private static string URL = @"https://trivia.runasp.net/TriviaApi/";
        private JsonSerializerOptions options;
        public TriviaService()
        {
            options = new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new System.Net.CookieContainer();
            handler.UseCookies = true;  
            client = new HttpClient(handler);
        }

        public async Task<Question> GetQuestion()
        {
            try
            {
                var response = await client.GetAsync($"{URL}GetRandomQuestion");
                var jsonString=await response.Content.ReadAsStringAsync();
                var question = JsonSerializer.Deserialize<Question>(jsonString, options);
                return  question;
            }
            catch(Exception ex) { throw; }
            
        }

    }
}
