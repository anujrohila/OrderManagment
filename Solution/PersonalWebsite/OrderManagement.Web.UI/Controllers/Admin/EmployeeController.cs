using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Web.Domain;
using OrderManagement.Web.Domain.Resources;
using OrderManagement.Web.BLL;

namespace OrderManagement.Web.UI.Controllers.Admin
{
    public class EmployeeController : Controller
    {
        #region [Deceleration]

        private EmployeeBusinessLogic employeeBusinessLogic { get; set; }

        #endregion

        #region [Coustructor]

        public EmployeeController()
        {
            employeeBusinessLogic = new EmployeeBusinessLogic();
        }

        #endregion

        #region [Action]

        [HttpGet]
        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// Get All Employee List
        /// </summary>
        /// <returns></returns>
        public PartialViewResult _PartialEmployeeList()
        {
            var employeeList = employeeBusinessLogic.GetAllEmployee(1);
            return PartialView(employeeList);
        }

        #endregion

        #region [Method]

        #endregion

    }
}
