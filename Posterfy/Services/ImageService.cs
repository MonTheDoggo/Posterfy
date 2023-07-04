using System.Net;

namespace Posterfy.Services
{
    public class ImageService
    {

        private readonly string spotifyEndpoint = "https://api.spotify.com/v1";

        public async void GetImageForAlbum(string albumId)
        {
            var base64Auth = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));
            Console.WriteLine(base64Auth);
            HttpClient client = new HttpClient();
            await client.PostAsync("https://accounts.spotify.com/api/token");
            //client.DefaultRequestHeaders.Add("Authorization", base64Auth);
            //client.DefaultRequestHeaders.Add("Content-Type", $"application/x-www-form-urlencoded");

            
            //var response = client.GetAsync($"{spotifyEndpoint}/albums/{albumId}");
            Console.WriteLine(base64Auth);
        }
    }
}
