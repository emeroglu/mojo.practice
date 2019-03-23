﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Abstract.Json
{
    public class JsonUser : JsonAny
    {
        public string email { get; set; }
        public string fbId { get; set; }
        public string name { get; set; }        
        public string picture { get; set; }
    }
}
