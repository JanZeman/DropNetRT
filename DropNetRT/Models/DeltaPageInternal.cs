﻿using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DropNetRT.Models
{
    internal class DeltaPageInternal
    {
        public string Cursor { get; set; }
        public bool Has_More { get; set; }
        public bool Reset { get; set; }
        public List<List<JRaw>> Entries { get; set; }
    }
}
