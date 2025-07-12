using CommerceCore.Api;
using CommerceCore.Api.Tools;
using Microsoft.AspNetCore.Mvc;
using Reserverio.BL.Tenants;

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
            
            return blOrganizations.GetOrganizations();
        }
    }
}
