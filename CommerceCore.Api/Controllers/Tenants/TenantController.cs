using CommerceCore.Api;
using CommerceCore.Api.Tools;
using Microsoft.AspNetCore.Mvc;
using Reserverio.BL.Tenants;
using ReserverioCore.ML.Tenants.Public.Tenants;

namespace Reserverio.Api.Controllers.Tenants
{
    [Route("organizaions")]
    [ApiController]
    public class TenantController : CustomController
    {
        private TenantsOrganizations blOrganizations = new TenantsOrganizations(Tool.configuration);

        /// <summary>
        /// Devuelve todas las organizaciones
        /// </summary>
        /// <returns></returns>
        [HttpGet("allOrganization")]
        public IActionResult OrganizationsAll()
        {
            
            var result = blOrganizations.GetOrganizations();
            return Ok(result);
        }

        /// <summary>
        /// Devuelve la busqueda de las organizaciones
        /// </summary>
        /// 
        /// <returns></returns>
        [HttpPost("searchOrganization")]
        public IActionResult SearchOrganization([FromBody] SearchPublicDto filters)
        {
            var result = blOrganizations.SearchOrganizations(filters);
            return Ok(result);
        }

    }
}
