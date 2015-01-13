using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using OrderManagement.Web.Domain;
using OrderManagement.Web.UI;

namespace OrderManagement.Web.UI
{
    public class BaseController : Controller
    {
        /// <summary>
        /// The below method will generate jave script file with json object same as resource file
        /// Object Name will be ``
        /// </summary>
        /// <returns></returns>
        public JavaScriptResult OrderManagementResource()
        {
            return ResourceJavaScripter.GetResourceScript(OrderManagement.Web.Domain.Resources.OrderManagementResource.ResourceManager);

        }

    }

}
