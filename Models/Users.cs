using System;
using System.Collections.Generic;

namespace SQL.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}
