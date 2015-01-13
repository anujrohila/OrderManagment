﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.Web.BLL.AdminService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderManagement.Web.BLL.AdminService.IAdminService")]
    public interface IAdminService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAdminLoginDetail", ReplyAction="http://tempuri.org/IAdminService/GetAdminLoginDetailResponse")]
        OrderManagement.Web.Domain.ServiceResult<OrderManagement.Web.Domain.tbl_AdminLogin_DTO> GetAdminLoginDetail(OrderManagement.Web.Domain.tbl_AdminLogin_DTO tbl_AdminLogin_DTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/InsertCategory", ReplyAction="http://tempuri.org/IAdminService/InsertCategoryResponse")]
        OrderManagement.Web.Domain.ServiceResult<bool> InsertCategory(OrderManagement.Web.Domain.tbl_Category_DTO tbl_Category_DTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/UpdateCategory", ReplyAction="http://tempuri.org/IAdminService/UpdateCategoryResponse")]
        OrderManagement.Web.Domain.ServiceResult<bool> UpdateCategory(OrderManagement.Web.Domain.tbl_Category_DTO tbl_Category_DTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/DeleteCategory", ReplyAction="http://tempuri.org/IAdminService/DeleteCategoryResponse")]
        OrderManagement.Web.Domain.ServiceResult<bool> DeleteCategory(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAdminCategory", ReplyAction="http://tempuri.org/IAdminService/GetAdminCategoryResponse")]
        OrderManagement.Web.Domain.ServiceResult<OrderManagement.Web.Domain.tbl_Category_DTO> GetAdminCategory(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllAdminCategory", ReplyAction="http://tempuri.org/IAdminService/GetAllAdminCategoryResponse")]
        OrderManagement.Web.Domain.ServiceResult<System.Collections.Generic.List<OrderManagement.Web.Domain.tbl_Category_DTO>> GetAllAdminCategory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetBoolData", ReplyAction="http://tempuri.org/IAdminService/GetBoolDataResponse")]
        bool GetBoolData();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceChannel : OrderManagement.Web.BLL.AdminService.IAdminService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceClient : System.ServiceModel.ClientBase<OrderManagement.Web.BLL.AdminService.IAdminService>, OrderManagement.Web.BLL.AdminService.IAdminService
    {
        
        public AdminServiceClient()
        {
        }
        
        public AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public OrderManagement.Web.Domain.ServiceResult<OrderManagement.Web.Domain.tbl_AdminLogin_DTO> GetAdminLoginDetail(OrderManagement.Web.Domain.tbl_AdminLogin_DTO tbl_AdminLogin_DTO)
        {
            return base.Channel.GetAdminLoginDetail(tbl_AdminLogin_DTO);
        }
        
        public OrderManagement.Web.Domain.ServiceResult<bool> InsertCategory(OrderManagement.Web.Domain.tbl_Category_DTO tbl_Category_DTO)
        {
            return base.Channel.InsertCategory(tbl_Category_DTO);
        }
        
        public OrderManagement.Web.Domain.ServiceResult<bool> UpdateCategory(OrderManagement.Web.Domain.tbl_Category_DTO tbl_Category_DTO)
        {
            return base.Channel.UpdateCategory(tbl_Category_DTO);
        }
        
        public OrderManagement.Web.Domain.ServiceResult<bool> DeleteCategory(int categoryId)
        {
            return base.Channel.DeleteCategory(categoryId);
        }
        
        public OrderManagement.Web.Domain.ServiceResult<OrderManagement.Web.Domain.tbl_Category_DTO> GetAdminCategory(int categoryId)
        {
            return base.Channel.GetAdminCategory(categoryId);
        }
        
        public OrderManagement.Web.Domain.ServiceResult<System.Collections.Generic.List<OrderManagement.Web.Domain.tbl_Category_DTO>> GetAllAdminCategory()
        {
            return base.Channel.GetAllAdminCategory();
        }
        
        public bool GetBoolData()
        {
            return base.Channel.GetBoolData();
        }
    }
}