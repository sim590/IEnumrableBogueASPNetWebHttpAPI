
using System;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Toto.Filters
{
    public class TotoActionFilter : ActionFilterAttribute
    {

        public TotoActionFilter() { }
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Console.WriteLine("OnActionExecuting");
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Console.WriteLine("OnActionExecuted");
        }
    }
}
