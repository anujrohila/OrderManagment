﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OrderManagementDatabaseEntities : DbContext
    {
        public OrderManagementDatabaseEntities()
            : base("name=OrderManagementDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_AdminLogin> tbl_AdminLogin { get; set; }
        public DbSet<tblAdminLogin> tblAdminLogins { get; set; }
        public DbSet<tblCity> tblCities { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<tblFavouriteOrganization> tblFavouriteOrganizations { get; set; }
        public DbSet<tblOrder> tblOrders { get; set; }
        public DbSet<tblOrderItem> tblOrderItems { get; set; }
        public DbSet<tblOrderStatu> tblOrderStatus { get; set; }
        public DbSet<tblOrganization> tblOrganizations { get; set; }
        public DbSet<tblPayment> tblPayments { get; set; }
        public DbSet<tblSMSQueue> tblSMSQueues { get; set; }
    }
}
