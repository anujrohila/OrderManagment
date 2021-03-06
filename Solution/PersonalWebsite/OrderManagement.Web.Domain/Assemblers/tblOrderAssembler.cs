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
    /// Assembler for <see cref="tblOrder"/> and <see cref="tblOrderDTO"/>.
    /// </summary>
    public static partial class tblOrderAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblOrderDTO"/> converted from <see cref="tblOrder"/>.</param>
        static partial void OnDTO(this tblOrder entity, tblOrderDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblOrder"/> converted from <see cref="tblOrderDTO"/>.</param>
        static partial void OnEntity(this tblOrderDTO dto, tblOrder entity);

        /// <summary>
        /// Converts this instance of <see cref="tblOrderDTO"/> to an instance of <see cref="tblOrder"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblOrderDTO"/> to convert.</param>
        public static tblOrder ToEntity(this tblOrderDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblOrder();

            entity.OrderId = dto.OrderId;
            entity.OrderDateTime = dto.OrderDateTime;
            entity.RequesterLoginId = dto.RequesterLoginId;
            entity.RequesterOrganizationId = dto.RequesterOrganizationId;
            entity.RecieverOrganizationId = dto.RecieverOrganizationId;
            entity.StatusId = dto.StatusId;
            entity.LastStatusDateTime = dto.LastStatusDateTime;
            entity.IsHandleByEmployeeId = dto.IsHandleByEmployeeId;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblOrder"/> to an instance of <see cref="tblOrderDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblOrder"/> to convert.</param>
        public static tblOrderDTO ToDTO(this tblOrder entity)
        {
            if (entity == null) return null;

            var dto = new tblOrderDTO();

            dto.OrderId = entity.OrderId;
            dto.OrderDateTime = entity.OrderDateTime;
            dto.RequesterLoginId = entity.RequesterLoginId;
            dto.RequesterOrganizationId = entity.RequesterOrganizationId;
            dto.RecieverOrganizationId = entity.RecieverOrganizationId;
            dto.StatusId = entity.StatusId;
            dto.LastStatusDateTime = entity.LastStatusDateTime;
            dto.IsHandleByEmployeeId = entity.IsHandleByEmployeeId;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblOrderDTO"/> to an instance of <see cref="tblOrder"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblOrder> ToEntities(this IEnumerable<tblOrderDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblOrder"/> to an instance of <see cref="tblOrderDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblOrderDTO> ToDTOs(this IEnumerable<tblOrder> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
