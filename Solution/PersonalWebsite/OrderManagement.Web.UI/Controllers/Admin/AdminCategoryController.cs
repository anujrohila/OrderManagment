using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Web.Domain;
using OrderManagement.Web.Domain.Resources;
using OrderManagement.Web.BLL;

namespace OrderManagement.Web.UI
{
    [AdminAuthorization]
    public class AdminCategoryController : Controller
    {
        #region [Deceleration]

        private AdminCategoryBusinessLogic adminCategoryBusinessLogic { get; set; }

        #endregion

        #region [Coustructor]

        public AdminCategoryController()
        {
            adminCategoryBusinessLogic = new AdminCategoryBusinessLogic();
        }

        #endregion

        #region [Action]


        [HttpGet]
        public ActionResult Index()
        {
            AdminCategoryModel AdminCategoryModel = new AdminCategoryModel();
            AdminCategoryModel.CategoryList = adminCategoryBusinessLogic.GetAllAdminCategory();
            return View(AdminCategoryModel);
        }

        /// <summary>
        /// List All AJAX user device allocation
        /// </summary>
        /// <returns></returns>
        
        public PartialViewResult _CategoryList()
        {
            var categoryList = adminCategoryBusinessLogic.GetAllAdminCategory();
            return PartialView(categoryList);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();

        }

        #endregion

        #region [Method]

        #endregion

    }
}

