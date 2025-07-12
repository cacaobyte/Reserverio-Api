using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC;
using CommerceCore.BL;
using CommerceCore.DAL.Commerce;
using NuGet.Configuration;

namespace Reserverio.BL.Tenants
{
    public class Tenants : LogicBase
    {
        public Tenants(Configuration settings)
        {
            configuration = settings;
        }

        public dynamic GetMenuPlan(int aplicacion, string plan)
        {
            try
            {
                using (SoftByte db = new SoftByte(configuration.appSettings.cadenaSql))
                {
                    return db.Organizations.ToList();   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
