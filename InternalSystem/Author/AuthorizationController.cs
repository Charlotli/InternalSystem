using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace InternalSystem.Server.Author
{

    public class AuthorizationController: Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }
    }
}
