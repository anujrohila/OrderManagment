using OrderManagement.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Web.BLL
{
    public class AdminCategoryBusinessLogic
    {
        #region [Declaration]

        #endregion

        #region [Methods

        /// <summary>
        /// Get All user device usages
        /// </summary>
        /// <returns></returns>
        public tbl_AdminLogin_DTO GetAdminLoginDetail(tbl_AdminLogin_DTO tbl_AdminLogin_DTO)
        {
            var adminLoginDetails = ServiceReference.AdminServiceClient.GetAdminLoginDetail(tbl_AdminLogin_DTO);
            if (adminLoginDetails.Success)
            {
                return adminLoginDetails.Value;
            }
            else
            {
                return null;
            }

        }


        /// <summary>
        /// Insert Category
        /// </summary>
        /// <returns></returns>
        public bool InsertCategory(tbl_Category_DTO tbl_Category_DTO)
        {
            var result = ServiceReference.AdminServiceClient.InsertCategory(tbl_Category_DTO);
            if (result.Success)
            {
                return result.Value;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Update Category
        /// </summary>
        /// <returns></returns>
        public bool UpdateCategory(tbl_Category_DTO tbl_Category_DTO)
        {
            var result = ServiceReference.AdminServiceClient.UpdateCategory(tbl_Category_DTO);
            if (result.Success)
            {
                return result.Value;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <returns></returns>
        public bool DeleteCategory(int categoryId)
        {
            var result = ServiceReference.AdminServiceClient.DeleteCategory(categoryId);
            if (result.Success)
            {
                return result.Value;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get category details
        /// </summary>
        /// <returns></returns>
        public tbl_Category_DTO GetAdminCategory(int categoryId)
        {
            var result = ServiceReference.AdminServiceClient.GetAdminCategory(categoryId);
            if (result.Success)
            {
                return result.Value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get all categorys
        /// </summary>
        /// <returns></returns>
        public List<tbl_Category_DTO> GetAllAdminCategory()
        {
            var result = ServiceReference.AdminServiceClient.GetAllAdminCategory();
            if (result.Success)
            {
                return result.Value;
            }
            else
            {
                return null;
            }
        }


        #endregion
    }
}
