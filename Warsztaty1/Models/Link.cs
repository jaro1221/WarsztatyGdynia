﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warsztaty1.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}