﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Models
{
    class OfficialHollidays : BaseModel
    {
        public string Date { get; set; }
        public string Name { get; set; }
    }
}
