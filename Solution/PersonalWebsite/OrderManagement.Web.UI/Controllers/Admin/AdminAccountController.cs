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
    public class AdminAccountController : Controller
    {
        #region [Deceleration]

        private AdminAccountBusinessLogic adminAccountBusinessLogic { get; set; }

        #endregion

        #region [Coustructor]

        public AdminAccountController()
        {
            adminAccountBusinessLogic = new AdminAccountBusinessLogic();
        }

        #endregion

        #region [Action]


        [HttpGet]
        public ActionResult Login()
        {
            Session["AdminId"] = null;
            LoginModel loginModel = new LoginModel();
            loginModel.ModelMessage = new List<ModelMessage>();
            loginModel.PageHeaderModel.Title = OrderManagementResource.lblLogin;
            loginModel.PageHeaderModel.MetaKeyword = "Login,Admin,AnujRohila.com";
            loginModel.PageHeaderModel.MetaKeyword = "This is blogs website.";
            loginModel.PageHeaderModel.CannonicalLink = this.Request.Url.AbsoluteUri.ToString();
            return View(loginModel);
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                //Convert login model to admin login dto
                tbl_AdminLogin_DTO adminLoginDTO = new tbl_AdminLogin_DTO();
                adminLoginDTO.UserName = loginModel.UserName;
                adminLoginDTO.Password = loginModel.Password;
                var loginReponse = adminAccountBusinessLogic.GetAdminLoginDetail(adminLoginDTO);
                if (loginReponse != null)
                {
                    Session["AdminId"] = loginReponse.AdminLoginId;
                    Session.Timeout = 20;
                    return RedirectToAction("Index", "AdminHome");
                }
                else
                {
                    loginModel.ModelMessage.Add(new ModelMessage { Code = 1, Message = OrderManagementResource.msgIncorrectUserNameAndPassword, Type = MessageType.Error });
                }
                return View(loginModel);
            }
            else
            {
                return View(loginModel);
            }

        }

        public ActionResult Register()
        {
            return View();
        }

        #endregion

        #region [Method]

        #endregion

    }
}
