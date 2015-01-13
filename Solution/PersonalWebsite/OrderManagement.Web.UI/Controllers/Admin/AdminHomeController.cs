using OrderManagement.Web.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagement.Web.UI.Controllers.Admin
{
    [AdminAuthorization]
    public class AdminHomeController : Controller
    {
        #region [Deceleration]

        //private AdminAccountBusinessLogic adminAccountBusinessLogic { get; set; }

        #endregion

        #region [Coustructor]

        public AdminHomeController()
        {

        }

        #endregion

        #region [Action]


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region [Method]

        #endregion
    }
}
