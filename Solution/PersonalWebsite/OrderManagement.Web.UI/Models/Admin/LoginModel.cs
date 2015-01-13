using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderManagement.Web.UI;
using System.ComponentModel.DataAnnotations;
using OrderManagement.Web.Domain.Resources;
using OrderManagement.Web.Domain;

namespace OrderManagement.Web.UI
{
    public class LoginModel : CommonModel
    {

        [Required(ErrorMessageResourceName = "validationRequiredUserName", ErrorMessageResourceType = typeof(OrderManagementResource))]
        [Display(ResourceType = typeof(OrderManagementResource), Name = "lblUserName")]
        public String UserName { get; set; }


        [Display(ResourceType = typeof(OrderManagementResource), Name = "lblPassword")]
        [Required(ErrorMessageResourceName = "validationRequiredPassword", ErrorMessageResourceType = typeof(OrderManagementResource))]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}