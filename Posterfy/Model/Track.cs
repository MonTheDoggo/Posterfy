using System.Text.Json;

namespace Posterfy.Model
{
    public class Track
    {
        public string Href { get; set; } = null;
        public TrackItem[] Items { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
