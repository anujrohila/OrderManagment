//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-01-21 - 18:22:51
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
    public partial class tblSMSQueueDTO
    {
        [DataMember()]
        public Int32 RowId { get; set; }

        [DataMember()]
        public String MobileNo { get; set; }

        [DataMember()]
        public String Message { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreationDateTime { get; set; }
    }
}