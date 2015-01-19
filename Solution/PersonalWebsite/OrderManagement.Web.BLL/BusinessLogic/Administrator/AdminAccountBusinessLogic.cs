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
        public tblAdminLoginDTO GetAdminLoginDetail(tblAdminLoginDTO tblAdminLoginDTO)
        {
            try
            {
                LogGenerator.Info(string.Format("GetAdminLoginDetail-{0}", tblAdminLoginDTO));
                var user = ServiceReference.AdminServiceClient.GetAdminLoginDetail(tblAdminLoginDTO);
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
