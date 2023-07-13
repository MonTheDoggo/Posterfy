using System.Text.Json;

namespace Posterfy.Model
{
    public class TrackItem
    {
        public Artist[] Artists { get; set; } = null;
        public string[] Available_Markets { get; set; } = null;
        public int Disc_Number { get; set; } = 0;
        public int Duration_Ms { get; set; } = 0;
        public bool Explicit { get; set; } = false;
        public ExternalUrl External_Urls { get; set; } = null;
        public string Href { get; set; } = null;
        public string Id { get; set; } = null;
        public bool Is_Local { get; set; } = false;
        public string Name { get; set; } = null;
        public string Preview_Url { get; set; } = null;
        public int Track_Number { get; set; } = 0;
        public string Type { get; set; } = null;
        public string Uri { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
