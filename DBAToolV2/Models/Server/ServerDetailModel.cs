using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBAToolV2.Models.Server
{
    public class ServerDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Memory { get; set; }
        public int CpuCore { get; set; }
        public float CpuSpeed { get; set; }
        public DateTime PurchaseDate { get; set; } // Just store as an int for BC     
        //public Status Status { get; set; }
        public string ImageUrl { get; set; }
        // public virtual IEnumerable<Database> Databases { get; set; }
    }
}
