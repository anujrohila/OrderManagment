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
    
    public partial class tblCity
    {
        public tblCity()
        {
            this.tblOrganizations = new HashSet<tblOrganization>();
        }
    
        public int CityId { get; set; }
        public string CityName { get; set; }
    
        public virtual ICollection<tblOrganization> tblOrganizations { get; set; }
    }
}
