﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_pro.model
{
    internal class Admin
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
    }
}
