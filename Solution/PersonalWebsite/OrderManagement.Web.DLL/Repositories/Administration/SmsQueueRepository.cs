using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Web.Database;
using OrderManagement.Web.Domain;

namespace OrderManagement.Web.DLL
{
    public class SmsQueueRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public SmsQueueRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Add SMS Queue
        /// </summary>
        /// <returns></returns>
        public bool Add(tblSMSQueueDTO tblSMSQueueDTO)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                tblSMSQueueDTO.CreationDateTime = DateTime.Now;
                OrderManagementDataContext.tblSMSQueues.Add(tblSMSQueueDTO.ToEntity());
                return OrderManagementDataContext.SaveChanges() > 0;
            }
        }


        #endregion
    }
}
