//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/01/18 - 22:03:44
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using OrderManagement.Web.Domain;
using OrderManagement.Web.Database;

namespace OrderManagement.Web.Domain.Assemblers
{

    /// <summary>
    /// Assembler for <see cref="tblOrderItem"/> and <see cref="tblOrderItemDTO"/>.
    /// </summary>
    public static partial class tblOrderItemAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblOrderItemDTO"/> converted from <see cref="tblOrderItem"/>.</param>
        static partial void OnDTO(this tblOrderItem entity, tblOrderItemDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblOrderItem"/> converted from <see cref="tblOrderItemDTO"/>.</param>
        static partial void OnEntity(this tblOrderItemDTO dto, tblOrderItem entity);

        /// <summary>
        /// Converts this instance of <see cref="tblOrderItemDTO"/> to an instance of <see cref="tblOrderItem"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblOrderItemDTO"/> to convert.</param>
        public static tblOrderItem ToEntity(this tblOrderItemDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblOrderItem();

            entity.ItemId = dto.ItemId;
            entity.OrderId = dto.OrderId;
            entity.ItemName = dto.ItemName;
            entity.Quantity = dto.Quantity;
            entity.QuantityType = dto.QuantityType;
            entity.Prority = dto.Prority;
            entity.Status = dto.Status;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblOrderItem"/> to an instance of <see cref="tblOrderItemDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblOrderItem"/> to convert.</param>
        public static tblOrderItemDTO ToDTO(this tblOrderItem entity)
        {
            if (entity == null) return null;

            var dto = new tblOrderItemDTO();

            dto.ItemId = entity.ItemId;
            dto.OrderId = entity.OrderId;
            dto.ItemName = entity.ItemName;
            dto.Quantity = entity.Quantity;
            dto.QuantityType = entity.QuantityType;
            dto.Prority = entity.Prority;
            dto.Status = entity.Status;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblOrderItemDTO"/> to an instance of <see cref="tblOrderItem"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblOrderItem> ToEntities(this IEnumerable<tblOrderItemDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblOrderItem"/> to an instance of <see cref="tblOrderItemDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblOrderItemDTO> ToDTOs(this IEnumerable<tblOrderItem> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
