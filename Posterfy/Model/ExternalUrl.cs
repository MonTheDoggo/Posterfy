using System.Text.Json;

namespace Posterfy.Model
{
    public class ExternalUrl
    {
        public string Spotify { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
