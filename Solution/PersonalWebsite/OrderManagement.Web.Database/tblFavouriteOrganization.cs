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
    
    public partial class tblFavouriteOrganization
    {
        public int FavouriteId { get; set; }
        public Nullable<int> FavOrganizationId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> CreationOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
