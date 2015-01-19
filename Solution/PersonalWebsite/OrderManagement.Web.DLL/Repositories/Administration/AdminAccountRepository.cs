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
        public tblAdminLoginDTO GetAdminLoginDetail(tblAdminLoginDTO tblAdminLoginDTO)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                return (from admin in OrderManagementDataContext.tblAdminLogins
                        where admin.UserName == tblAdminLoginDTO.UserName
                              && admin.Password == admin.Password
                        select new tblAdminLoginDTO()
                        {
                            AdminId = admin.AdminId,
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
