using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BISM.Models.MainSystem;

namespace BISM.helpers
{
    public class AuthorizedAction : ActionFilterAttribute
    {
        
        
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
            base.OnActionExecuting(filterContext);
            if (filterContext.HttpContext.Session.GetString("UserCode") == null)
            //if(filterContext.HttpContext.User.Identity.IsAuthenticated == false)
            {

                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new
                        {
                            Controller = "Account",
                            Action = "Login",
                            returnUrl = filterContext.HttpContext.Request.Path.ToUriComponent()
                        }));
                return;
            }

            var menus = JsonConvert.DeserializeObject<List<Systemusermenu>>(filterContext.HttpContext.Session.GetString("menus"));
            var listParent = JsonConvert.DeserializeObject<List<Systemusermenu>>(filterContext.HttpContext.Session.GetString("menus")).Select(s => s.ParentId);
            var listChild = JsonConvert.DeserializeObject<List<Systemusermenu>>(filterContext.HttpContext.Session.GetString("menus")).Select(s => s.ChildId);
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];           
            var permissions = JsonConvert.DeserializeObject<List<Systempermission>>(filterContext.HttpContext.Session.GetString("permissions"));
            var objects = JsonConvert.DeserializeObject<List<Systemobject>>(filterContext.HttpContext.Session.GetString("object"));

            if (!objects.Where(s => s.ActionName == Convert.ToString(actionName) && s.ControllerName == Convert.ToString(controllerName)).Any()){
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "controller", "Account" }, { "action", "Login" } });
                return;
            }
           


        }
    }
}
