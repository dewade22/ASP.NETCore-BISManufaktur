﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace BISM.helpers { 
public static class NavigationIndicatorHelper
{
    /*public static string MakeActiveClass(this IUrlHelper urlHelper, string controller, string action)
    {
        try
        {
            string result = "active";
            string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
            string methodName = urlHelper.ActionContext.RouteData.Values["action"].ToString();
            if (string.IsNullOrEmpty(controllerName)) return null;
            if (controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
            {
                if (methodName.Equals(action, StringComparison.OrdinalIgnoreCase))
                {
                    return result;
                }
            }
            return null;
        }
        catch (Exception)
        {
            return null;
        }
    }*/
    public static string MakeActiveClass(this IUrlHelper urlHelper, string link)
        {
            try
            {
                string result = "active";
                if (string.IsNullOrEmpty(link)) return null;
                string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                string methodName = urlHelper.ActionContext.RouteData.Values["action"].ToString();
                var controller = link.Split("/")[1];
                var action = link.Split("/")[2];
                if (controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
                {
                    if (methodName.Equals(action, StringComparison.OrdinalIgnoreCase))
                    {
                        return result;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
}
}