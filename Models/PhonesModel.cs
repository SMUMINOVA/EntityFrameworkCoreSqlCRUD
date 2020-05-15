using System;
using System.Collections.Generic;

namespace SQL.Models
{
    public partial class PhonesModel
    {
        public int Id { get; set; }
        public int? PhonesId { get; set; }
        public string Name { get; set; }
    }
}
