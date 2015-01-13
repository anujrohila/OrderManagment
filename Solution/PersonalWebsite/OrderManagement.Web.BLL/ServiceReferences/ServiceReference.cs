using System;
using OrderManagement.Web.Domain;

namespace OrderManagement.Web.BLL
{
    public static class ServiceReference
    {


        private static string AdminServiceUri
        {
            get
            {
                //return Convert.ToString(System.Configuration.ConfigurationSettings.AppSettings["AdminServiceUri"].ToString());
                return Convert.ToString("http://localhost/OrderManagement.Web.Services/Services/Admin/AdminService.svc");
            }
        }




        /// <summary>
        /// Get SystemConfigurationClient
        /// </summary>
        private static OrderManagement.Web.BLL.AdminService.AdminServiceClient _adminServiceClient;
        public static OrderManagement.Web.BLL.AdminService.AdminServiceClient AdminServiceClient
        {
            get
            {
                if (_adminServiceClient == null)
                {
                    System.ServiceModel.EndpointAddress address = new System.ServiceModel.EndpointAddress(AdminServiceUri);
                    System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode.None);
                    binding.MaxReceivedMessageSize = Int32.MaxValue;

                    binding.CloseTimeout = new TimeSpan(0, 30, 0);
                    binding.OpenTimeout = new TimeSpan(0, 30, 0);
                    binding.ReceiveTimeout = new TimeSpan(0, 30, 0);
                    binding.SendTimeout = new TimeSpan(0, 30, 0);


                    _adminServiceClient = new OrderManagement.Web.BLL.AdminService.AdminServiceClient(binding, address);
                }
                return _adminServiceClient;
            }
        }
    }
}
