using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using todoclient.Models;

namespace todoclient.Services
{
    public class ResponseManager
    {
        private readonly HttpClient httpClient;

        public ResponseManager(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Todo>> GetAllEpisodes()
        {
            string Url = "https://localhost:5001/Todo";
            var result = await httpClient.GetAsync(Url);
            result.EnsureSuccessStatusCode();
            var response = await result.Content.ReadAsStringAsync();
            var TodoResponse = JsonConvert.DeserializeObject<List<Todo>>(response);
            Console.WriteLine(response);
            return TodoResponse;
        }


        //public async Task<List<Episode>> GetAllEpisodes()
        //{
        //    string Url = "episodes";
        //    var result = await httpClient.GetAsync(Url);
        //    result.EnsureSuccessStatusCode();
        //    var response = await result.Content.ReadAsStringAsync();
        //    var EpisodesResponse = JsonConvert.DeserializeObject<EpisodesResponse>(response);
        //    if (EpisodesResponse.Success)
        //    {
        //        return EpisodesResponse.Episodes;
        //    }
        //    else
        //    {
        //        return new List<Episode>();
        //    }
        //}
    }
}
