using ARM_Engineer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer.Technic
{
   public class Technic
   {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IDClassObjectOperation { get; set; }
        public int IDBrandEquipment { get; set; }
        public string? InventoryNumber { get; set; }
        public string? IdentificationNumber { get; set; }
        public int IDVehicleManagementСategory { get; set; }
        public string? TransportDestinations { get; set; }
        public string? StateRegistrationMark { get; set; }
        public DateTime YearRelease { get; set; }
        public ClassObjectOperation ClassObjectOperation
        {
            get
            {
                return Database.DataBase.GetClassObjectOperationByID(IDClassObjectOperation);
            }
        }
        public BrandEquipment BrandEquipment
        {
            get
            {
                return Database.DataBase.GetBrandEquipmentByID(IDBrandEquipment);
            }
        }
        public VehicleManagementCategory VehicleManagementCategory
        {
            get
            {
                return Database.DataBase.GetVehicleManagementCategoryByID(IDVehicleManagementСategory);
            }
        }
    }
}
