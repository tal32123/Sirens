using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;
using Server.Models;

namespace APM.WebAPI.Models
{
    /// <summary>
    /// Stores the data in a json file so that no database is required for this
    /// sample application
    /// </summary>
    public class SirenRepository
    {
        /// <summary>
        /// Creates a new siren with default values
        /// </summary>
        /// <returns></returns>
        internal Siren Create()
        {
            Siren siren = new Siren
            {
                Start = DateTime.Now
            };
            return siren;
        }

        /// <summary>
        /// Retrieves the list of sirens.
        /// </summary>
        /// <returns></returns>
        internal List<Siren> Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/siren.json");

            var json = System.IO.File.ReadAllText(filePath);

            var sirens = JsonConvert.DeserializeObject<List<Siren>>(json);

            return sirens;
        }

        /// <summary>
        /// Saves a new siren.
        /// </summary>
        /// <param name="siren"></param>
        /// <returns></returns>
        internal Siren Save(Siren siren)
        {
            // Read in the existing sirens
            var sirens = this.Retrieve();

            // Assign a new Id
            var maxId = sirens.Max(s => s.ID);
            siren.ID = maxId + 1;
            sirens.Add(siren);

            WriteData(sirens);
            return siren;
        }

        /// <summary>
        /// Updates an existing siren
        /// </summary>
        /// <param name="id"></param>
        /// <param name="siren"></param>
        /// <returns></returns>
        internal Siren Save(int id, Siren siren)
        {
            // Read in the existing sirens
            var sirens = this.Retrieve();

            // Locate and replace the item
            var itemIndex = sirens.FindIndex(s => s.ID == siren.ID);
            if (itemIndex > 0)
            {
                sirens[itemIndex] = siren;
            }
            else
            {
                return null;
            }

            WriteData(sirens);
            return siren;
        }

        private bool WriteData(List<Siren> sirens)
        {
            // Write out the Json
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/siren.json");

            var json = JsonConvert.SerializeObject(sirens, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, json);

            return true;
        }

    }
}