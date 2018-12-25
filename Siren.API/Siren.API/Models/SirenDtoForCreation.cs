using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Siren.API.Models
{
    public class SirenDtoForCreation
    {
        public string Description { get; set; }
        public string Severity { get; set; }
        public string Start { get; set; }
        public string End { get; set; }


    }
}
