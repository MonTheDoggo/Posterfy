using System.Text.Json;

namespace Posterfy.Model
{
    public class Artist
    {
        public ExternalUrl External_Urls { get; set; } = null;
        public string Href { get; set; } = null;
        public string Id { get; set; } = null;
        public string Name { get; set; } = null;
        public string Type { get; set; } = null;
        public string Uri { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
