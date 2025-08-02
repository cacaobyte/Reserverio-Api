using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public List<TenantsLists> SearchOrganizations(SearchPublicDto search)
        {
            try
            {
                var result = new List<TenantsLists>();

                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {

                    if (search != null)
                    {
                        throw new Exception("Los parametros de busquedas no son validos");
                    }

                    if (search.Type == "A")
                    {
                        if (search.Longitud == null | search.Latitud == null )
                        {
                            throw new Exception("Los campos de busqueda del mapa se encuentran vacios");
                        }
                        result = SearchLocationTenants(search.Latitud, search.Longitud);
                    } else if (search.Type == "B")
                    {
                        if (search.Nombre == null && search.Descripcion == null )
                        {
                            throw new Exception("El campo de descripción y nombre no son validos para la busqueda");
                        }

                    }else if (search.Type == "C")
                    {
                        if (search.Categoria == null)
                        {
                            throw new Exception("La categoria de busqueda no se ingreso correctamente");
                        }
                    }
                    else
                    {
                        throw new Exception("Tipo de busqueda invalido");
                    }

                        return result;
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
        public List<TenantsLists> SearchLocationTenants(double Latitud, double Longitud)
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
