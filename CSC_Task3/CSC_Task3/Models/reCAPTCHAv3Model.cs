using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC_Task3.Models
{
	public class reCAPTCHAv3Model
	{
        public class TokenResponse
        {
            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("score")]
            public decimal Score { get; set; }

            [JsonProperty("action")]
            public string Action { get; set; }

            [JsonProperty("error-codes")]
            public List<string> ErrorCodes { get; set; }
        }
    }
}