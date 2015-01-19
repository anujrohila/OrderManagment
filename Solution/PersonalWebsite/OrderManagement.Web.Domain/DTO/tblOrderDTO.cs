//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/01/18 - 22:03:41
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
    public partial class tblOrderDTO
    {
        [DataMember()]
        public Int32 OrderId { get; set; }

        [DataMember()]
        public Nullable<DateTime> OrderDateTime { get; set; }

        [DataMember()]
        public Nullable<Int32> RequesterLoginId { get; set; }

        [DataMember()]
        public Nullable<Int32> RequesterOrganizationId { get; set; }

        [DataMember()]
        public Nullable<Int32> RecieverOrganizationId { get; set; }

        [DataMember()]
        public Nullable<Int32> StatusId { get; set; }

        [DataMember()]
        public Nullable<DateTime> LastStatusDateTime { get; set; }

        [DataMember()]
        public Nullable<Int32> IsHandleByEmployeeId { get; set; }

        [DataMember()]
        public Int32 tblOrderStatu_StatusId { get; set; }

        [DataMember()]
        public List<Int32> tblOrderItems_ItemId { get; set; }

        public tblOrderDTO()
        {
        }

        public tblOrderDTO(Int32 orderId, Nullable<DateTime> orderDateTime, Nullable<Int32> requesterLoginId, Nullable<Int32> requesterOrganizationId, Nullable<Int32> recieverOrganizationId, Nullable<Int32> statusId, Nullable<DateTime> lastStatusDateTime, Nullable<Int32> isHandleByEmployeeId, Int32 tblOrderStatu_StatusId, List<Int32> tblOrderItems_ItemId)
        {
			this.OrderId = orderId;
			this.OrderDateTime = orderDateTime;
			this.RequesterLoginId = requesterLoginId;
			this.RequesterOrganizationId = requesterOrganizationId;
			this.RecieverOrganizationId = recieverOrganizationId;
			this.StatusId = statusId;
			this.LastStatusDateTime = lastStatusDateTime;
			this.IsHandleByEmployeeId = isHandleByEmployeeId;
			this.tblOrderStatu_StatusId = tblOrderStatu_StatusId;
			this.tblOrderItems_ItemId = tblOrderItems_ItemId;
        }
    }
}
