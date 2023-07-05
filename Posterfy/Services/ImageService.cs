using Microsoft.Net.Http.Headers;
using System.Net;
using System.Web;

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

        public async void GetImageForAlbum(string albumId)
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
            var response = client.GetAsync($"{spotifyEndpoint}/albums/{albumId}");
            Console.WriteLine(await response.Result.Content.ReadAsStringAsync());
        }
    }
}
