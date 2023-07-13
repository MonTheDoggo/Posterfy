using System.Text.Json;

namespace Posterfy.Model
{
    public class Image
    {
        public int Height { get; set; } = 0;
        public string Url { get; set; } = null;
        public int Width { get; set; } = 0;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
