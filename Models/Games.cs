using System;
using System.Collections.Generic;

namespace SQL.Models
{
    public partial class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Players { get; set; }
        public double Mark { get; set; }
    }
}
