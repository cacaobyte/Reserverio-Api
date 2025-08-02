using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserverioCore.ML.Tenants.Public.Tenants
{
    public class SearchPublicDto
    {
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Categoria { get; set; }
        public string? Type { get; set; }
    }
}
