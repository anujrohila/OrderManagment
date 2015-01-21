using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Web.Domain;
using OrderManagement.Web.DLL;

namespace OrderManagement.Web.BLL
{
    public static class SmsQueueBusinessLogic
    {
        #region [Declaration]

        #endregion

        #region [Methods
        /// <summary>
        /// Add SMS Queue
        /// </summary>
        /// <returns></returns>
        public static bool Add(tblSMSQueueDTO tblSMSQueueDTO)
        {
            try
            {
                LogGenerator.Info(string.Format("Add-{0}", tblSMSQueueDTO));
                var smsQueueRepository = new SmsQueueRepository();
                return smsQueueRepository.Add(tblSMSQueueDTO);
            }
            catch (Exception ex)
            {
                LogGenerator.Error("Add", ex);
            }
            return false;
        }

        #endregion
    }
}
