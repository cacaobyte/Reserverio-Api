using CommerceCore.Api.Tools;
using Microsoft.AspNetCore.Mvc;

namespace Reserverio.Api.Controllers.Tenants
{
    public class TenantController : CustomController
    {
        [HttpGet]
        public IActionResult OrganizationsAll()
        {
            return Ok("Prueba del controladores exitosa");
        }
    }
}
