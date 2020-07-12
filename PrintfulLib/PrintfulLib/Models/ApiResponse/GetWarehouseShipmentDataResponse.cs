﻿using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetWarehouseShipmentDataResponse
    {
        [JsonProperty("code")] 
        public int StatusCode { get; set; }

        [JsonProperty("result")]
        public WarehouseShipment WarehouseShipment { get; set; }
    }
}