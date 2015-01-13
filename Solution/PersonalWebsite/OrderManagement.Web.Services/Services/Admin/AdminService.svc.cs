using OrderManagement.Web.DLL;
using OrderManagement.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderManagement.Web.Services.Services.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdminService.svc or AdminService.svc.cs at the Solution Explorer and start debugging.
    public class AdminService : IAdminService
    {

        #region [Admin Account]

        /// <summary>
        /// Get AdminLogin details
        /// </summary>
        /// <returns></returns>
        public ServiceResult<tbl_AdminLogin_DTO> GetAdminLoginDetail(tbl_AdminLogin_DTO tbl_AdminLogin_DTO)
        {
            var adminAccountRepository = new AdminAccountRepository();
            var adminDetail = new ServiceResult<tbl_AdminLogin_DTO>();
            try
            {
                adminDetail.Value = adminAccountRepository.GetAdminLoginDetail(tbl_AdminLogin_DTO);
                adminDetail.Success = true;
               
            }
            catch (Exception exception)
            {
                adminDetail.ExceptionInfo = new ExceptionInfo(exception);
                adminDetail.Success = false;
            }
            return adminDetail;
        }


        #endregion

        #region [Admin Category]

        /// <summary>
        /// Insert Category
        /// </summary>
        /// <returns></returns>
        public ServiceResult<bool> InsertCategory(tbl_Category_DTO tbl_Category_DTO)
        {
            var adminCategoryRepository = new AdminCategoryRepository();
            var result = new ServiceResult<bool>();
            try
            {
                result.Value = adminCategoryRepository.InsertCategory(tbl_Category_DTO);
                result.Success = true;
            }
            catch (Exception exception)
            {
                result.ExceptionInfo = new ExceptionInfo(exception);
                result.Success = false;
            }
            return result;
        }

        /// <summary>
        /// Update Category
        /// </summary>
        /// <returns></returns>
        public ServiceResult<bool> UpdateCategory(tbl_Category_DTO tbl_Category_DTO)
        {
            var adminCategoryRepository = new AdminCategoryRepository();
            var result = new ServiceResult<bool>();
            try
            {
                result.Value = adminCategoryRepository.UpdateCategory(tbl_Category_DTO);
                result.Success = true;
            }
            catch (Exception exception)
            {
                result.ExceptionInfo = new ExceptionInfo(exception);
                result.Success = false;
            }
            return result;
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <returns></returns>
        public ServiceResult<bool> DeleteCategory(int categoryId)
        {
            var adminCategoryRepository = new AdminCategoryRepository();
            var result = new ServiceResult<bool>();
            try
            {
                result.Value = adminCategoryRepository.DeleteCategory(categoryId);
                result.Success = true;
            }
            catch (Exception exception)
            {
                result.ExceptionInfo = new ExceptionInfo(exception);
                result.Success = false;
            }
            return result;
        }

        /// <summary>
        /// Get category details
        /// </summary>
        /// <returns></returns>
        public ServiceResult<tbl_Category_DTO> GetAdminCategory(int categoryId)
        {
            var adminCategoryRepository = new AdminCategoryRepository();
            var result = new ServiceResult<tbl_Category_DTO>();
            try
            {
                result.Value = adminCategoryRepository.GetAdminCategory(categoryId);
                result.Success = true;
            }
            catch (Exception exception)
            {
                result.ExceptionInfo = new ExceptionInfo(exception);
                result.Success = false;
            }
            return result;
        }

        /// <summary>
        /// Get all categorys
        /// </summary>
        /// <returns></returns>
        public ServiceResult<List<tbl_Category_DTO>> GetAllAdminCategory()
        {
            var adminCategoryRepository = new AdminCategoryRepository();
            var result = new ServiceResult<List<tbl_Category_DTO>>();
            try
            {
                result.Value = adminCategoryRepository.GetAllAdminCategory();
                result.Success = true;
            }
            catch (Exception exception)
            {
                result.ExceptionInfo = new ExceptionInfo(exception);
                result.Success = false;
            }
            return result;
        }

        #endregion

        #region [Extra]

        public bool GetBoolData()
        {
            return true;
        }

        #endregion

    }
}
