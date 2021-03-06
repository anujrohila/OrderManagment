﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Web.Domain;
using OrderManagement.Web.Domain.Resources;
using OrderManagement.Web.BLL;

namespace OrderManagement.Web.UI.Controllers.Admin
{
    public class AccountController : Controller
    {
        #region [Deceleration]

        private AdminAccountBusinessLogic adminAccountBusinessLogic { get; set; }

        #endregion

        #region [Coustructor]

        public AccountController()
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
                var employeeDTO = new tblEmployeeDTO();
                employeeDTO.MobileNo = loginModel.UserName;
                employeeDTO.Password = loginModel.Password;
                var loginReponse = adminAccountBusinessLogic.GetAdminLoginDetail(employeeDTO);
                if (loginReponse != null)
                {
                    if (loginReponse.IsActive == true)
                    {
                        Session["AdminId"] = loginReponse.EmployeeId;
                        Session.Timeout = 20;
                        return RedirectToAction("Index", "AdminHome");
                    }
                    else
                    {
                        loginModel.ModelMessage.Add(new ModelMessage { Code = 1, Message = OrderManagementResource.msgDiableUserAccount, Type = MessageType.Error });
                    }
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
            var tblOrganizationDTO = new tblOrganizationDTO();
            return View(tblOrganizationDTO);
        }

        [HttpPost]
        public ActionResult Register(tblOrganizationDTO tblOrganizationDTOModel)
        {
            if (ModelState.IsValid)
            {
                tblOrganizationDTOModel = CheckRegistrationValidation(tblOrganizationDTOModel);
                if (ModelState.IsValid)
                {
                    //Convert login model to admin login dto
                    tblOrganizationDTOModel.CreationOn = DateTime.Now;
                    tblOrganizationDTOModel.CityId = 1;
                    tblOrganizationDTOModel.IsActive = true;
                    tblOrganizationDTOModel.IsWorkingStatus = true;
                    tblOrganizationDTOModel.IsWorkingStatusMessge = OrderManagementResource.lblAvailable;
                    tblOrganizationDTOModel.Password = DateTime.Now.ToString("ssfff").Substring(0, 4);
                    var registerResult = adminAccountBusinessLogic.Register(tblOrganizationDTOModel);
                    if (registerResult > 0)
                    {
                        SmsQueueBusinessLogic.Add(new tblSMSQueueDTO { MobileNo = tblOrganizationDTOModel.MobileNo, Message = "Register successsfully. your password is : " + tblOrganizationDTOModel.Password });
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        tblOrganizationDTOModel.ModelMessage.Add(new ModelMessage { Code = 1, Message = OrderManagementResource.msgTryagainLater, Type = MessageType.Error });
                    }
                }
            }
            return View(tblOrganizationDTOModel);
        }

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegisterSuccess()
        {
            return View();
        }


        #endregion

        #region [Method]

        private tblOrganizationDTO CheckRegistrationValidation(tblOrganizationDTO tblOrganizationDTOModel)
        {
            if (adminAccountBusinessLogic.IsMobileNoExists(tblOrganizationDTOModel.MobileNo) == true)
            {
                tblOrganizationDTOModel.ModelMessage.Add(new ModelMessage { Code = 1, Message = OrderManagementResource.msgMobileNoExists, Type = MessageType.Error });
                ModelState.AddModelError("MobileNo", OrderManagementResource.msgMobileNoExists);
            }
            else
            {
                if (adminAccountBusinessLogic.IsOrganizationExists(tblOrganizationDTOModel.OrganizationName) == true)
                {
                    tblOrganizationDTOModel.ModelMessage.Add(new ModelMessage { Code = 1, Message = OrderManagementResource.msgOrganizationNameExists, Type = MessageType.Error });
                    ModelState.AddModelError("OrganizationName", OrderManagementResource.msgOrganizationNameExists);
                }
            }
            return tblOrganizationDTOModel;
        }

        #endregion

    }
}
