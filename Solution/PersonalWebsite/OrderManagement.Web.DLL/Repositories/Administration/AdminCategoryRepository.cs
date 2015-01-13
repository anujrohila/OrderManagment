using OrderManagement.Web.Database;
using OrderManagement.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Web.DLL
{
    public class AdminCategoryRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public AdminCategoryRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Insert Category
        /// </summary>
        /// <returns></returns>
        public bool InsertCategory(tbl_Category_DTO tbl_Category_DTO)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                OrderManagementDataContext.tbl_Category.Add(tbl_Category_DTO.ToEntity());
                return OrderManagementDataContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Update Category
        /// </summary>
        /// <returns></returns>
        public bool UpdateCategory(tbl_Category_DTO tbl_Category_DTO)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var category = OrderManagementDataContext.tbl_Category.Find(tbl_Category_DTO.CategoryId);
                category.CatgeoryName = tbl_Category_DTO.CatgeoryName;
                category.AliasName = tbl_Category_DTO.AliasName;
                category.Description = tbl_Category_DTO.Description;
                category.IsActive = tbl_Category_DTO.IsActive;
                return OrderManagementDataContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <returns></returns>
        public bool DeleteCategory(int categoryId)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var category = OrderManagementDataContext.tbl_Category.Find(categoryId);
                OrderManagementDataContext.tbl_Category.Remove(category);
                return OrderManagementDataContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Get category details
        /// </summary>
        /// <returns></returns>
        public tbl_Category_DTO GetAdminCategory(int categoryId)
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var category = OrderManagementDataContext.tbl_Category.Find(categoryId);
                return category.ToDTO();
            }
        }

        /// <summary>
        /// Get all categorys
        /// </summary>
        /// <returns></returns>
        public List<tbl_Category_DTO> GetAllAdminCategory()
        {
            using (var OrderManagementDataContext = new OrderManagementDatabaseEntities())
            {
                var allCategory = (from category in OrderManagementDataContext.tbl_Category
                                   orderby category.CategoryId
                                   select new tbl_Category_DTO
                                   {
                                       CatgeoryName = category.CatgeoryName,
                                       CategoryId = category.CategoryId,
                                       AliasName = category.AliasName,
                                       Description = category.Description,
                                       CreationDateTime = category.CreationDateTime,
                                       IsActive = category.IsActive
                                   }).ToList();
                return allCategory;

            }
        }

        #endregion
    }
}
