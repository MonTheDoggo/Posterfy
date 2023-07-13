﻿using System.Text.Json;

namespace Posterfy.Model
{
    public class ClientValue
    {
        public string ClientId { get; set; } = null;
        public string ClientSecret { get; set; } = null;

        public string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
