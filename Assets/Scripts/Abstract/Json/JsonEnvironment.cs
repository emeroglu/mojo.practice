﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Abstract.Json
{
    public class JsonEnvironment : JsonAny
    {
        public string name { get; set; }
        public string lastUpdate { get; set; }
    }
}
