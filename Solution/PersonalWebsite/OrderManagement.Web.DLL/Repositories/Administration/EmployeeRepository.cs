using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Web.Database;
using OrderManagement.Web.Domain;

namespace OrderManagement.Web.DLL
{
    public class EmployeeRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public EmployeeRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Employee
        /// </summary>
        /// <returns></returns>
        public tblEmployeeDTO GetAllEmployee(int organizationId)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                return (from employee in OrderManagementDataContext.tblEmployees
                        where employee.OrganizationId == organizationId
                        select new tblEmployeeDTO()
                        {
                            EmployeeId = employee.EmployeeId,
                            FirstName = employee.FirstName,
                            LastName = employee.LastName,
                            JobTitle = employee.JobTitle,
                            MobileNo = employee.MobileNo,
                            IsActive = employee.IsActive,
                            IsDeleted = employee.IsDeleted,
                            IsPrimary = employee.IsPrimary,
                            CreationOn = employee.CreationOn
                        }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int employeeId)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var employee = OrderManagementDataContext.tblEmployees.Find(employeeId);
                employee.IsDeleted = true;
                return OrderManagementDataContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool Update(tblEmployeeDTO tblEmployeeDTO)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var employee = OrderManagementDataContext.tblEmployees.Find(tblEmployeeDTO.EmployeeId);
                employee.FirstName = tblEmployeeDTO.FirstName;
                employee.LastName = tblEmployeeDTO.LastName;
                employee.JobTitle = tblEmployeeDTO.JobTitle;
                employee.MobileNo = tblEmployeeDTO.MobileNo;
                employee.ModifiedOn = tblEmployeeDTO.ModifiedOn;
                employee.IsActive = tblEmployeeDTO.IsActive;
                return OrderManagementDataContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Change Password
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool ChangePassword(int employeeId, string password)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var employee = OrderManagementDataContext.tblEmployees.Find(employeeId);
                employee.Password = password;
                return OrderManagementDataContext.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
