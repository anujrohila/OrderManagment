//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/01/18 - 22:03:39
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OrderManagement.Web.Domain
{
    [DataContract()]
    public partial class tblEmployeeDTO
    {
        [DataMember()]
        public Int32 EmployeeId { get; set; }

        [DataMember()]
        public String FirstName { get; set; }

        [DataMember()]
        public String LastName { get; set; }

        [DataMember()]
        public String JobTitle { get; set; }

        [DataMember()]
        public String MobileNo { get; set; }

        [DataMember()]
        public String Password { get; set; }

        [DataMember()]
        public Nullable<Int32> OrganizationId { get; set; }

        [DataMember()]
        public Nullable<bool> IsPrimary { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreationOn { get; set; }

        [DataMember()]
        public Nullable<DateTime> ModifiedOn { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsActive { get; set; }

        [DataMember()]
        public String DeviceId { get; set; }

        [DataMember()]
        public String DeviceType { get; set; }

        [DataMember()]
        public String DeviceToken { get; set; }

        [DataMember()]
        public Nullable<bool> IsDeleted { get; set; }

        [DataMember()]
        public Int32 tblOrganization_OrganizationId { get; set; }

    }
}
