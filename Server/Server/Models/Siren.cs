using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models
{
    public class Siren
    {
        public string Description { get; set; }
        public string Severity { get; set; }
        public DateTime Start { get; set; }
        public string End { get; set; }
        public string ID { get; set; }


    }
}