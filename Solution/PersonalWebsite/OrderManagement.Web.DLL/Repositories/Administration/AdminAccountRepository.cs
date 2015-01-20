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

        /// <summary>
        /// Register user
        /// </summary>
        /// <returns></returns>
        public int Register(tblOrganizationDTO tblOrganizationDTO)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var tblOrganization = new tblOrganization();
                if (tblOrganizationDTO.OrganizationId == 0)
                {
                    tblOrganization.FirstName = tblOrganizationDTO.FirstName;
                    tblOrganization.LastName = tblOrganizationDTO.LastName;
                    tblOrganization.MobileNo = tblOrganizationDTO.MobileNo;
                    tblOrganization.OrganizationName = tblOrganizationDTO.OrganizationName;
                    OrderManagementDataContext.tblOrganizations.Add(tblOrganization);
                }
                else
                {
                    tblOrganization = OrderManagementDataContext.tblOrganizations.Find(tblOrganizationDTO.OrganizationId);
                    tblOrganization.FirstName = tblOrganizationDTO.FirstName;
                    tblOrganization.LastName = tblOrganizationDTO.LastName;
                    tblOrganization.MobileNo = tblOrganizationDTO.MobileNo;
                    tblOrganization.OrganizationName = tblOrganizationDTO.OrganizationName;
                }
                tblOrganization.CityId = tblOrganizationDTO.CityId;
                tblOrganization.JobTitle = tblOrganizationDTO.JobTitle;
                tblOrganization.Address = tblOrganizationDTO.Address;
                tblOrganization.Latitute = tblOrganizationDTO.Latitute;
                tblOrganization.Logitute = tblOrganizationDTO.Logitute;
                tblOrganization.MapAddress = tblOrganizationDTO.MapAddress;
                tblOrganization.EmailAddress = tblOrganizationDTO.EmailAddress;
                tblOrganization.OrganizationWebsite = tblOrganizationDTO.OrganizationWebsite;
                tblOrganization.CreationOn = tblOrganizationDTO.CreationOn;
                tblOrganization.ModificationOn = tblOrganizationDTO.ModificationOn;
                tblOrganization.IsActive = tblOrganizationDTO.IsActive;
                tblOrganization.IsWorkingStatus = tblOrganizationDTO.IsWorkingStatus;
                tblOrganization.IsWorkingStatusMessge = tblOrganizationDTO.IsWorkingStatusMessge;
                OrderManagementDataContext.SaveChanges();
                return tblOrganization.OrganizationId;
            }
        }


        #endregion
    }
}
