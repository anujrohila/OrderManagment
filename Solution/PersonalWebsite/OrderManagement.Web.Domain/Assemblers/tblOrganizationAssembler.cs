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
    /// Assembler for <see cref="tblOrganization"/> and <see cref="tblOrganizationDTO"/>.
    /// </summary>
    public static partial class tblOrganizationAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblOrganizationDTO"/> converted from <see cref="tblOrganization"/>.</param>
        static partial void OnDTO(this tblOrganization entity, tblOrganizationDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblOrganization"/> converted from <see cref="tblOrganizationDTO"/>.</param>
        static partial void OnEntity(this tblOrganizationDTO dto, tblOrganization entity);

        /// <summary>
        /// Converts this instance of <see cref="tblOrganizationDTO"/> to an instance of <see cref="tblOrganization"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblOrganizationDTO"/> to convert.</param>
        public static tblOrganization ToEntity(this tblOrganizationDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblOrganization();

            entity.OrganizationId = dto.OrganizationId;
            entity.FirstName = dto.FirstName;
            entity.LastName = dto.LastName;
            entity.JobTitle = dto.JobTitle;
            entity.CityId = dto.CityId;
            entity.OrganizationName = dto.OrganizationName;
            entity.Address = dto.Address;
            entity.MobileNo = dto.MobileNo;
            entity.Latitute = dto.Latitute;
            entity.Logitute = dto.Logitute;
            entity.MapAddress = dto.MapAddress;
            entity.EmailAddress = dto.EmailAddress;
            entity.OrganizationWebsite = dto.OrganizationWebsite;
            entity.CreationOn = dto.CreationOn;
            entity.ModificationOn = dto.ModificationOn;
            entity.IsActive = dto.IsActive;
            entity.IsWorkingStatus = dto.IsWorkingStatus;
            entity.IsWorkingStatusMessge = dto.IsWorkingStatusMessge;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblOrganization"/> to an instance of <see cref="tblOrganizationDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblOrganization"/> to convert.</param>
        public static tblOrganizationDTO ToDTO(this tblOrganization entity)
        {
            if (entity == null) return null;

            var dto = new tblOrganizationDTO();

            dto.OrganizationId = entity.OrganizationId;
            dto.FirstName = entity.FirstName;
            dto.LastName = entity.LastName;
            dto.JobTitle = entity.JobTitle;
            dto.CityId = entity.CityId;
            dto.OrganizationName = entity.OrganizationName;
            dto.Address = entity.Address;
            dto.MobileNo = entity.MobileNo;
            dto.Latitute = entity.Latitute;
            dto.Logitute = entity.Logitute;
            dto.MapAddress = entity.MapAddress;
            dto.EmailAddress = entity.EmailAddress;
            dto.OrganizationWebsite = entity.OrganizationWebsite;
            dto.CreationOn = entity.CreationOn;
            dto.ModificationOn = entity.ModificationOn;
            dto.IsActive = entity.IsActive;
            dto.IsWorkingStatus = entity.IsWorkingStatus;
            dto.IsWorkingStatusMessge = entity.IsWorkingStatusMessge;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblOrganizationDTO"/> to an instance of <see cref="tblOrganization"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblOrganization> ToEntities(this IEnumerable<tblOrganizationDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblOrganization"/> to an instance of <see cref="tblOrganizationDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblOrganizationDTO> ToDTOs(this IEnumerable<tblOrganization> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}