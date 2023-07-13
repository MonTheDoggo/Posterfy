using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.Web;
using Newtonsoft.Json.Bson;
using Posterfy.Model;
using Single = System.Single;

namespace Posterfy.Services
{
    public class ImageService
    {
        private readonly string spotifyEndpoint = "https://api.spotify.com/v1";

        private TokenService tokenService;

        public ImageService(TokenService tokenService)
        {
            this.tokenService = tokenService;
        }

        public async Task GetImageForAlbum(string albumId)
        {
            await tokenService.GetToken();
            /*var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded")
            });*/
            
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenService.Token.Access_Token}");
            //client.DefaultRequestHeaders.Add("Content-Type", $"application/x-www-form-urlencoded");

            //var response = await client.PostAsync("https://accounts.spotify.com/api/token", content);
            //string responseContent = await response.Content.ReadAsStringAsync();
            var response = await client.GetAsync($"{spotifyEndpoint}/albums/{albumId}");
            string responseMessage = await response.Content.ReadAsStringAsync();
            Album album = JsonConvert.DeserializeObject<Album>(responseMessage);
            //Console.WriteLine(responseMessage);
            Console.WriteLine(album.ToString());
        }

        public async Task GetImageForSong(string songId)
        {
            await tokenService.GetToken();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenService.Token.Access_Token}");

            var response = await client.GetAsync($"{spotifyEndpoint}/tracks/{songId}");
            string responseMessage = await response.Content.ReadAsStringAsync();
            Single single = JsonConvert.DeserializeObject<Single>(responseMessage);
            Console.WriteLine(single.ToString());
            //Console.WriteLine(responseMessage);

        }
    }
}
