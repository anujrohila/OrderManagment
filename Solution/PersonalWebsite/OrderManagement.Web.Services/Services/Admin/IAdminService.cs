using OrderManagement.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderManagement.Web.Services.Services.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdminService" in both code and config file together.
    [ServiceContract]
    public interface IAdminService
    {
        
        #region [Admin Account]

        [OperationContract]
        ServiceResult<tblAdminLoginDTO> GetAdminLoginDetail(tblAdminLoginDTO tbl_AdminLogin_DTO);

        #endregion

        #region [Admin Category]

        //[OperationContract]
        //ServiceResult<bool> InsertCategory(tbl_Category_DTO tbl_Category_DTO);

        //[OperationContract]
        //ServiceResult<bool> UpdateCategory(tbl_Category_DTO tbl_Category_DTO);

        //[OperationContract]
        //ServiceResult<bool> DeleteCategory(int categoryId);

        //[OperationContract]
        //ServiceResult<tbl_Category_DTO> GetAdminCategory(int categoryId);

        //[OperationContract]
        //ServiceResult<List<tbl_Category_DTO>> GetAllAdminCategory();

        #endregion

        #region [Extra]

        [OperationContract]
        bool GetBoolData();

        #endregion
        
    }
}
