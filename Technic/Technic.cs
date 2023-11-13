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
        public int IDClassObjectOperation { get; set; }
        public string? IDBrandEquipment { get; set; }
        public string? InventoryNumber { get; set; }
        public string? IdentificationNumber { get; set; }
        public int IDVehicleManagementСategory { get; set; }
        public string? TransportDestinations { get; set; }
        public string? StateRegistrationMark { get; set; }
        public DateTime YearRelease { get; set; }
        public ClassObjectOperation classObjectOperation
        {
            get
            {
                return Database.DataBase.GetOrganizationByID(ID_Orgainzation);
            }
        }
        public Division Division
        {
            get
            {
                return Database.DataBase.GetDivisionByID(ID_Division);
            }
        }
        public Post Post
        {
            get
            {
                return Database.DataBase.GetPostByID(ID_Post);
            }
        }
    }
}
