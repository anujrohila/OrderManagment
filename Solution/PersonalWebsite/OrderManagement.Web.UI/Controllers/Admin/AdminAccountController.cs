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
                tblAdminLoginDTO adminLoginDTO = new tblAdminLoginDTO();
                adminLoginDTO.UserName = loginModel.UserName;
                adminLoginDTO.Password = loginModel.Password;
                var loginReponse = adminAccountBusinessLogic.GetAdminLoginDetail(adminLoginDTO);
                if (loginReponse != null)
                {
                    Session["AdminId"] = loginReponse.AdminId;
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

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(tblOrganizationDTO tblOrganizationDTOModel)
        {
            if (ModelState.IsValid)
            {
                //Convert login model to admin login dto
                tblAdminLoginDTO adminLoginDTO = new tblAdminLoginDTO();
                tblOrganizationDTOModel.CreationOn = DateTime.Now;
                tblOrganizationDTOModel.CityId = 1;
                tblOrganizationDTOModel.IsActive = true;
                tblOrganizationDTOModel.Password = Encryption.Encrypt(DateTime.Now.ToString("yyyy_mm_ss_HH_ss_fff")).Substring(0, 6);
                tblOrganizationDTOModel.IsWorkingStatus = true;
                tblOrganizationDTOModel.IsWorkingStatusMessge = OrderManagementResource.lblAvailable;
                var registerResult = adminAccountBusinessLogic.Register(tblOrganizationDTOModel);
                if (registerResult > 0)
                {
                    SmsQueueBusinessLogic.Add(new tblSMSQueueDTO { MobileNo = tblOrganizationDTOModel.MobileNo, Message = string.Format("Your password is :  {0}", tblOrganizationDTOModel.Password) });
                    return RedirectToAction("Login", "AdminAccount");
                }
                else
                {
                    //loginModel.ModelMessage.Add(new ModelMessage { Code = 1, Message = OrderManagementResource.msgIncorrectUserNameAndPassword, Type = MessageType.Error });
                }
                return View(tblOrganizationDTOModel);
            }
            else
            {
                return View(tblOrganizationDTOModel);
            }

        }


        #endregion

        #region [Method]

        #endregion

    }
}
