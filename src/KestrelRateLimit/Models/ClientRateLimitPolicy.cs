﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KestrelRateLimit
{
    public class ClientRateLimitPolicy
    {
        public string ClientId { get; set; }
        public List<ClientRateLimit> Limits { get; set; }
    }
}