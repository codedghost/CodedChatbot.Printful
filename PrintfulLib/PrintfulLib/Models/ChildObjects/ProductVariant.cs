﻿using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class ProductVariant
    {
        [JsonProperty("variant_id")]
        public int? VariantId { get; set; }

        [JsonProperty("product_id")]
        public int? ProductId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string DisplayName { get; set; }
    }
}