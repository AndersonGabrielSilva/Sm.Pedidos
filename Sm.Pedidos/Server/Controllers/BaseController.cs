using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sm.Pedidos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IHttpContextAccessor contextAccessor;
        private IHttpContextAccessor ContextAccessor
        {
            set
            {
                contextAccessor = value;

                Connect(contextAccessor.HttpContext.User);
            }
        }

        public BaseController(IHttpContextAccessor contextAccessor)
        {
            ContextAccessor = contextAccessor;
        }

        protected bool Connect(System.Security.Claims.ClaimsPrincipal user)
        {
            if (user == null || !user.Identity.IsAuthenticated)
                return false;

            //var claimValue = user.Claims.SingleOrDefault(x => x.Type == nameof(Variaveis.Valores.IdEntidade)).Value;


            return false;
        }
    }
}
