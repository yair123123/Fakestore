using Fakestore.Models;
using System.Net.Http.Json;

namespace HttpClientDemo
{
    public class JsonPlaceholderService
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceholderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Item>> GetPostsAsync()
        {
            var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
            response.EnsureSuccessStatusCode();
            var posts = await response.Content.ReadFromJsonAsync<List<Item>>();
            return posts;
        }

        public async Task<Item> GetPostAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://jsonplaceholder.typicode.com/posts/{id}");
            response.EnsureSuccessStatusCode();
            var post = await response.Content.ReadFromJsonAsync<Item>();
            return post;
        }

        public async Task<Item> CreatePostAsync(Item newPost)
        {
            var response = await _httpClient.PostAsJsonAsync("https://jsonplaceholder.typicode.com/posts", newPost);
            response.EnsureSuccessStatusCode();
            var createdPost = await response.Content.ReadFromJsonAsync<Item>();
            return createdPost;
        }

        public async Task UpdatePostAsync(int id, Item updatedPost)
        {
            var response = await _httpClient.PutAsJsonAsync($"https://jsonplaceholder.typicode.com/posts/{id}", updatedPost);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeletePostAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"https://jsonplaceholder.typicode.com/posts/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

  
}
