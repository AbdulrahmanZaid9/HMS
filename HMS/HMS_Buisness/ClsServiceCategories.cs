using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsServiceCategories
    {
        public byte CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Creates an empty service category object with default values.
        public ClsServiceCategories()
        {
            this.CategoryId = 0;
            this.CategoryName = string.Empty;
        }

        // Creates a service category object from an existing ID and name.
        public ClsServiceCategories(byte categoryId, string categoryName)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }

        // Retrieves a service category by its ID and returns it as a ClsServiceCategories object, or null if not found.
        public static ClsServiceCategories FindCategoryById(byte categoryId)
        {
            string categoryName = string.Empty;

            if (ClsServiceCategoriesData.FindCategoryById(ref categoryId, ref categoryName))
            {
                return new ClsServiceCategories(
                    categoryId,
                    categoryName
                );
            }
            else
                return null;

        }

        // Retrieves all service category records.
        public static DataTable GetAllServiceCategories()
        {
            return ClsServiceCategoriesData.GetAllServiceCategories();
        }



    }
}