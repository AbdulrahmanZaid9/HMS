using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsServices
    {

        public byte ServiceId { get; set; }
        public string ServiceName { get; set; }
        public byte CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ClsServiceCategories Category { get; set; }

        // Creates a new, unsaved service with default values and an empty linked category.
        public ClsServices()
        {
            this.ServiceId = 0;
            this.ServiceName = string.Empty;
            this.CategoryId = 0;
            this.Price = 0;
            this.Description = string.Empty;
            this.IsActive = true;
            this.Category = ClsServiceCategories.FindCategoryById(this.CategoryId);
        }

        // Creates a service object from existing data, loading its linked category.
        public ClsServices(byte serviceId, string serviceName, byte categoryId, decimal price, string description, bool isActive)
        {
            this.ServiceId = serviceId;
            this.ServiceName = serviceName;
            this.CategoryId = categoryId;
            this.Price = price;
            this.Description = description;
            this.IsActive = isActive;
            this.Category = ClsServiceCategories.FindCategoryById(this.CategoryId);

        }

        // Retrieves a service by its ID and returns it as a ClsServices object, or null if not found.
        public static ClsServices FindServiceById(byte serviceId)
        {

            byte categoryId = 0;
            string serviceName = string.Empty;
            decimal price = 0;
            string description = string.Empty;
            bool isActive = false;


            if (ClsServicesData.FindServiceById(serviceId, ref categoryId, ref serviceName, ref price, ref description, ref isActive))
            {
                return new ClsServices(
                    serviceId,
                    serviceName,
                    categoryId,
                    price,
                    description,
                    isActive
                );
            }
            else
                return null;


        }

        // Retrieves all active services along with their category names.
        public static DataTable GetAllServices()
        {
            return ClsServicesData.GetAllServices();
        }

        // Retrieves all service names and their corresponding IDs.
        public static DataTable GetAllServiceNamesAndId()
        {
            return ClsServicesData.GetAllServiceNamesAndId();
        }

        // Updates the price of a service by its service ID.
        public static bool UpdatePriceById(byte serviceId, decimal price)
        {
            return ClsServicesData.UpdatePriceById(serviceId, price);
        }
    }
}