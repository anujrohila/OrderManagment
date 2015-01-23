using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Web.Domain;
using OrderManagement.Web.DLL;

namespace OrderManagement.Web.BLL
{
    public class EmployeeBusinessLogic
    {
        #region [Declaration]

        #endregion

        #region [Methods

        /// <summary>
        /// Get All Employee
        /// </summary>
        /// <returns></returns>
        public tblEmployeeDTO GetAllEmployee(int organizationId)
        {
            try
            {
                LogGenerator.Info(string.Format("GetAllEmployee-{0}", organizationId));
                var employeeRepository = new EmployeeRepository();
                return employeeRepository.GetAllEmployee(organizationId);
            }
            catch (Exception ex)
            {
                LogGenerator.Error("GetAllEmployee", ex);
            }
            return null;
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int employeeId)
        {
            try
            {
                LogGenerator.Info(string.Format("DeleteEmployee-{0}", employeeId));
                var employeeRepository = new EmployeeRepository();
                return employeeRepository.DeleteEmployee(employeeId);
            }
            catch (Exception ex)
            {
                LogGenerator.Error("DeleteEmployee", ex);
            }
            return false;
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool Update(tblEmployeeDTO tblEmployeeDTO)
        {
            try
            {
                LogGenerator.Info(string.Format("Update-{0}", tblEmployeeDTO));
                var employeeRepository = new EmployeeRepository();
                return employeeRepository.Update(tblEmployeeDTO);
            }
            catch (Exception ex)
            {
                LogGenerator.Error("Update", ex);
            }
            return false;
        }

        /// <summary>
        /// Change Password
        /// </summary>
        /// <param name="mobileNo"></param>
        /// <returns></returns>
        public bool ChangePassword(int employeeId, string password)
        {
            try
            {
                LogGenerator.Info(string.Format("ChangePassword-{0}-{1}", employeeId, password));
                var employeeRepository = new EmployeeRepository();
                return employeeRepository.ChangePassword(employeeId, password);
            }
            catch (Exception ex)
            {
                LogGenerator.Error("ChangePassword", ex);
            }
            return false;
        }

        #endregion
    }
}
