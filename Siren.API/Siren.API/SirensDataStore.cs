using Siren.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Siren.API
{
    public class SirensDataStore
    {
        public static SirensDataStore Current { get; } = new SirensDataStore();

    public List<SirenDto> Sirens { get; set; }


        public SirensDataStore()
        {
            Sirens = new List<SirenDto>()
        {
            new SirenDto()
            {
                Description = "dto test",
                Severity = "2",
                Start="now",
                End ="later",
                ID ="1234"
            },
             new SirenDto()
            {
                Description = "dto is under a test",
                Severity = "4",
                Start="t+5",
                End ="t+20",
                ID ="421"
            }

        };
        }
    }
}
