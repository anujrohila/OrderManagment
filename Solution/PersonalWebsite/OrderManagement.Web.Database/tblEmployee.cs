//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.Web.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmployee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public Nullable<bool> IsPrimary { get; set; }
        public Nullable<System.DateTime> CreationOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceToken { get; set; }
    
        public virtual tblOrganization tblOrganization { get; set; }
    }
}
