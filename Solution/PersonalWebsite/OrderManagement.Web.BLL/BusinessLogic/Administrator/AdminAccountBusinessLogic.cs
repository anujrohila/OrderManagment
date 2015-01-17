using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Web.Domain;

namespace OrderManagement.Web.BLL
{
    public class AdminAccountBusinessLogic
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
            try
            {
                //LogGenerator.Info(string.Format("GetAdminLoginDetail-{0}", tbl_AdminLogin_DTO));
                var user = ServiceReference.AdminServiceClient.GetAdminLoginDetail(tbl_AdminLogin_DTO);
                if (user.Success)
                {
                    return user.Value;
                }
                else
                {
                    LogGenerator.Error(user.ExceptionInfo.ToString());
                }
            }
            catch (Exception ex)
            {
                LogGenerator.Error("GetUser", ex);
            }
            return null;
        }

        #endregion
    }
}
