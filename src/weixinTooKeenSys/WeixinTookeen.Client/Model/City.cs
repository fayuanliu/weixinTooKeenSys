﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeixinTookeen.Client.Model
{
    public class City:BaseEntity
    {
        public string Name { get; set; }

        public int? Pid { get; set; }
    }
}
