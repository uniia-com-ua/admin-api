﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniiaAdmin.Data.Models;

namespace UniiaAdmin.Data.Dtos
{
    public class UniversityDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
    }
}
