using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Sigma3.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Sigma3.Services
{
    public class NasaService
    {
        private const string BaseUrl = "https://api.nasa.gov/planetary";
        private const string APIKey = "LJ9bOaowNyyDMb9sdnUND5MeaH8qB0KSw0Q7vpNF";
        private const string FullUrl = "https://api.nasa.gov/planetary/apod?api_key=LJ9bOaowNyyDMb9sdnUND5MeaH8qB0KSw0Q7vpNF";
        private readonly HttpClient _httpClient;
        public NasaService(HttpClient httpClient) =>
        _httpClient = httpClient;
        public async Task<NasaViewModel> GetPicturesAsync()
        {
            // Simulate some network traffic
            var nasaResponse = await _httpClient.GetFromJsonAsync<NasaAPOD>(FullUrl);

            if (nasaResponse is null)
            {
                throw new HttpRequestException("Repositories not returned on response");
            }

            NasaViewModel picture = new NasaViewModel(nasaResponse.Title, nasaResponse.Explanation, nasaResponse.Url);
            return picture;
        }
    }
}