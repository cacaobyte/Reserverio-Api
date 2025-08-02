using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CC;
using CommerceCore.BL;
using CommerceCore.DAL.Commerce;
using Humanizer;
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
                        if (search.Nombre == null)
                        {
                            throw new Exception("El campo de descripción y nombre no son validos para la busqueda");
                        }

                        result = SearchNameOrDescriptionTenants(search.Nombre);

                    }
                    else if (search.Type == "C")
                    {
                        if (search.Categoria == null)
                        {
                            throw new Exception("La categoria de busqueda no se ingreso correctamente");
                        }
                        result = SearchNameCategorieTenants(search.Categoria);
                    }
                    else if (search.Type == "D")
                    {
                        if (search.Longitud == null | search.Latitud == null)
                        {
                            throw new Exception("Los campos de busqueda del mapa se encuentran vacios");
                        }
                        result = SearchLocationTenants(search.Latitud, search.Longitud, search.Km);
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
        public List<TenantsLists> SearchLocationTenants(decimal Latitud, decimal Longitud, double radioKm = 3)
        {
            try
            {
                const double earthRadius = 6371; // Radio de la Tierra en km

                // Convertir a double para trigonometría
                double lat = (double)Latitud;
                double lon = (double)Longitud;

                // Bounding box
                double latRadius = radioKm / 111.0;
                double lonRadius = radioKm / (111.0 * Math.Cos(lat * Math.PI / 180.0));

                double minLat = lat - latRadius;
                double maxLat = lat + latRadius;
                double minLon = lon - lonRadius;
                double maxLon = lon + lonRadius;

                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {
                   var result  = new List<TenantsLists>();

                    result = db.Organizations
                .Join(db.Tenants, o => o.Id, t => t.ParentTenantId, (o, t) => new { o, t })
                .Where(x =>
                    x.t.Latitude >= (decimal)minLat && x.t.Latitude <= (decimal)maxLat &&
                    x.t.Longitude >= (decimal)minLon && x.t.Longitude <= (decimal)maxLon)
                .ToList()
                .Where(x =>
                {
                    double tenantLat = (double)x.t.Latitude * Math.PI / 180.0;
                    double tenantLon = (double)x.t.Longitude * Math.PI / 180.0;
                    double userLat = lat * Math.PI / 180.0;
                    double userLon = lon * Math.PI / 180.0;

                    double dLat = tenantLat - userLat;
                    double dLon = tenantLon - userLon;

                    double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                               Math.Cos(userLat) * Math.Cos(tenantLat) *
                               Math.Pow(Math.Sin(dLon / 2), 2);
                    double c = 2 * Math.Asin(Math.Sqrt(a));
                    double distance = earthRadius * c;

                    return distance <= radioKm;
                })
                .Select(x => new TenantsLists
                {
                    nameTenant = x.t.Name,
                    nameLegal = x.o.LegalName,
                    website = x.o.Website,
                    correo = x.t.ContactEmail,
                    phone = x.t.ContactPhone,
                    description = x.o.Description,
                    logourl = x.t.LogoUrl,
                    industry = x.t.Industry,
                    latitud = x.t.Latitude,
                    longitude = x.t.Longitude,
                    addressline = x.t.AddressLine,
                    country = x.t.Country,
                    stateOrRegion = x.t.StateOrRegion,
                    city = x.t.City,
                    idTenant = x.t.Id,
                    idOrganization = x.o.Id,
                })
                .ToList();

       


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
        public List<TenantsLists> SearchNameOrDescriptionTenants(string name)
        {
            try
            {
                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {
                    var result = new List<TenantsLists>();

                    result = db.Organizations.Join(db.Tenants, o => o.Id, t => t.ParentTenantId, (o, t) => new { o, t })
                        .Where(x => EF.Functions.ILike(x.t.Name, $"%{name}%") ||
                                    EF.Functions.ILike(x.o.Description, $"%{name}%"))
                        .Select(x => new TenantsLists
                        {
                            nameTenant = x.t.Name,
                            nameLegal = x.o.LegalName,
                            website = x.o.Website,
                            correo = x.t.ContactEmail,
                            phone = x.t.ContactPhone,
                            description = x.o.Description,
                            logourl = x.t.LogoUrl,
                            industry = x.t.Industry,
                            latitud = x.t.Latitude,
                            longitude = x.t.Longitude,
                            addressline = x.t.AddressLine,
                            country = x.t.Country,
                            stateOrRegion = x.t.StateOrRegion,
                            city = x.t.City,
                            idTenant = x.t.Id,
                            idOrganization = x.o.Id,
                        }).ToList();


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
        public List<TenantsLists> SearchNameCategorieTenants(string categorie)
        {
            try
            {
                using (Reserveriodb db = new Reserveriodb(configuration.appSettings.cadenaSql))
                {
                    var result = new List<TenantsLists>();

                    result = db.Organizations.Join(db.Tenants, o => o.Id, t => t.ParentTenantId, (o, t) => new { o, t })
                        .Where(x => x.t.Industry == categorie)
                        .Select(x => new TenantsLists
                        {
                            nameTenant = x.t.Name,
                            nameLegal = x.o.LegalName,
                            website = x.o.Website,
                            correo = x.t.ContactEmail,
                            phone = x.t.ContactPhone,
                            description = x.o.Description,
                            logourl = x.t.LogoUrl,
                            industry = x.t.Industry,
                            latitud = x.t.Latitude,
                            longitude = x.t.Longitude,
                            addressline = x.t.AddressLine,
                            country = x.t.Country,
                            stateOrRegion = x.t.StateOrRegion,
                            city = x.t.City,
                            idTenant = x.t.Id,
                            idOrganization = x.o.Id,
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
