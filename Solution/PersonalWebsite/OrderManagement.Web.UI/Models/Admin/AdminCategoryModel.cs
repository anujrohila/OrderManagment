using OrderManagement.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Web.UI
{
    public class AdminCategoryModel 
    {
        public List<tbl_Category_DTO> CategoryList { get; set; }
    }
}