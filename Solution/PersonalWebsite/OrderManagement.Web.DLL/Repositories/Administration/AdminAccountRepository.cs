using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Web.Database;
using OrderManagement.Web.Domain;

namespace OrderManagement.Web.DLL
{
    public class AdminAccountRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public AdminAccountRepository()
        {

        }

        #endregion

        #region [Methods]


        /// <summary>
        /// Get AdminLogin details
        /// </summary>
        /// <returns></returns>
        public tbl_AdminLogin_DTO GetAdminLoginDetail(tbl_AdminLogin_DTO tbl_AdminLogin_DTO)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                return (from admin in OrderManagementDataContext.tbl_AdminLogin
                        where admin.UserName == tbl_AdminLogin_DTO.UserName
                              && admin.Password == admin.Password
                        select new tbl_AdminLogin_DTO()
                        {
                            AdminLoginId = admin.AdminLoginId,
                            FirstName = admin.FirstName,
                            LastName = admin.LastName,
                            UserName = admin.UserName,
                            Password = admin.Password,
                            IsActive = admin.IsActive
                        }).FirstOrDefault();
            }
        }

        #endregion
    }
}
