using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
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
            return TodoResponse;
        }



        public async Task<Todo> PostTodo(TodoDto todo)
        {
            string Url = "https://localhost:5001/Todo";
            var result = await httpClient.PostAsJsonAsync(Url, todo);
            result.EnsureSuccessStatusCode();
            var response = await result.Content.ReadAsStringAsync();
            var TodoResponse = JsonConvert.DeserializeObject<Todo>(response);
            return TodoResponse;
        }


        public async Task<int> DeleteTodo(int id)
        {
            string Url = $"https://localhost:5001/Todo/{id}";
            var result = await httpClient.DeleteAsync(Url);
            result.EnsureSuccessStatusCode();
            var response = await result.Content.ReadAsStringAsync();
            var TodoResponse = JsonConvert.DeserializeObject<int>(response);
            return TodoResponse;
        }

        public async Task<int> Checkbox(Todo todo)
        {
            Console.WriteLine(todo.id);
            string Url = $"https://localhost:5001/Todo/{todo.id}";
            UpdateDto updateDto = new()
            {
                title = todo.title,
                done = !todo.done
                
            };
            var result = await httpClient.PutAsJsonAsync(Url, updateDto);
            result.EnsureSuccessStatusCode();
            var response = await result.Content.ReadAsStringAsync();
            var TodoResponse = JsonConvert.DeserializeObject<int>(response);
            Console.WriteLine(TodoResponse);
            return TodoResponse;
        }

        //string Url = "episodes";
        //var result = await httpClient.PostAsJsonAsync(Url, Episode);
        //result.EnsureSuccessStatusCode();
        //    var response = await result.Content.ReadAsStringAsync();
        //var EpisodeResponse = JsonConvert.DeserializeObject<EpisodeResponse>(response);
        //    if (EpisodeResponse.Success)
        //    {
        //        return EpisodeResponse.Episode;
        //    }
        //    else
        //    {
        //        return new Episode();


        //public async Task PostTodo(TodoDto todo)
        //{
        //    string jsonTodo = JsonConvert.SerializeObject(todo);
        //    StringContent httpContent = new StringContent(jsonTodo);
        //    string Url = "https://localhost:5001/Todo";
        //    var response = await httpClient.PostAsync(Url, httpContent);
        //    response.EnsureSuccessStatusCode();

            
        //}


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
