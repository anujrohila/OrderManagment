using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Web.Domain;
using OrderManagement.Web.DLL;

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
                //var user = ServiceReference.AdminServiceClient.GetAdminLoginDetail(tblAdminLoginDTO);
                var adminAccountRepository = new AdminAccountRepository();
                return adminAccountRepository.GetAdminLoginDetail(tblAdminLoginDTO);
            }
            catch (Exception ex)
            {
                LogGenerator.Error("GetAdminLoginDetail", ex);
            }
            return null;
        }

        /// <summary>
        /// Register user
        /// </summary>
        /// <returns></returns>
        public int Register(tblOrganizationDTO tblOrganizationDTO)
        {
            try
            {
                LogGenerator.Info(string.Format("Register-{0}", tblOrganizationDTO));
                //var user = ServiceReference.AdminServiceClient.GetAdminLoginDetail(tblAdminLoginDTO);
                var adminAccountRepository = new AdminAccountRepository();
                return adminAccountRepository.Register(tblOrganizationDTO);
            }
            catch (Exception ex)
            {
                LogGenerator.Error("Register", ex);
            }
            return 0;
        }

        #endregion
    }
}
