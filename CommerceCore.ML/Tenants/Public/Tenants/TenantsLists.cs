using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserverioCore.ML.Tenants.Public.Tenants
{
    public class TenantsLists
    {
        public string? nameTenant { get; set; }
        public string? nameLegal { get; set; }
        public string? website { get; set; }
        public string? correo { get; set; }
        public string? phone { get; set; }
        public string? description { get; set; }
        public string? logourl { get; set; }
        public string? industry { get; set; }
        public decimal? latitud { get; set; }
        public decimal? longitude { get; set; }
        public string? addressline { get; set; }
        public string? country { get; set; }
        public string? stateOrRegion { get; set; }
        public string? city { get; set; }
        public int idTenant { get; set; }
        public int idOrganization { get; set; }
    }
}
