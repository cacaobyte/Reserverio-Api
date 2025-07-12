using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC;
using CommerceCore.BL;
using CommerceCore.DAL.Commerce;
using Microsoft.EntityFrameworkCore;
using NuGet.Configuration;

namespace Reserverio.BL.Tenants
{
    public class TenantsOrganizations : LogicBase
    {
        public TenantsOrganizations(Configuration settings)
        {
            configuration = settings;
        }

        public dynamic GetOrganizations()
        {
            try
            {
                // Intentar abrir la conexión explícitamente para validar
                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {
                    // Esta línea valida si la conexión se puede abrir
                    db.Database.OpenConnection();

                    // Mensaje opcional de confirmación de conexión (puedes ponerlo en logs)
                    Console.WriteLine("✅ Conexión exitosa a la base de datos Neon");

                    var organizations = db.Organizations.ToList();

                    // Cierra la conexión manualmente (aunque el using también lo haría)
                    db.Database.CloseConnection();

                    return organizations;
                }
            }
            catch (Exception ex)
            {
                // Incluye la cadena de conexión en modo desarrollo si lo necesitas
                throw new Exception("❌ Error de conexión o consulta a Neon: " + ex.Message);
            }
        }

    }
}
