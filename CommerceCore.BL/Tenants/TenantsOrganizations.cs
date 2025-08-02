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
using ReserverioCore.ML.Tenants.Public.Tenants;

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
                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {

                    var organizations = db.Organizations.ToList();

                    return organizations;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Cambiar con agregar un type identificador para diferentes tipos de busquedas
        public dynamic SearchOrganizations(SearchPublicDto search)
        {
            try
            {
                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {
                    var query = db.Organizations.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(search.Nombre))
                        query = query.Where(o => o.Name.ToLower().Contains(search.Nombre.ToLower()));

                    if (!string.IsNullOrWhiteSpace(search.Descripcion))
                        query = query.Where(o => o.Description.ToLower().Contains(search.Descripcion.ToLower()));

                

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Devuelve la busqueda de los tenants para pantalle de usuarios publicos
        /// </summary>
        /// 
        /// <returns></returns>
        public List<TenantsLists> SearchTenants(SearchPublicDto search)
        {
            try
            {
                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {
                   var result  = new List<TenantsLists>();

                    result = db.Organizations.Join(db.Tenants, o => o.Id, t => t.ParentTenantId, ( o, t ) => new { o, t })
                        .Select(x => new TenantsLists
                        {
                            nameTenant = x.t.Name,
                            nameLegal = x.o.LegalName,
                        }).ToList();
                        

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }





    }
}
