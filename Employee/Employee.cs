using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_Engineer.Models;

namespace ARM_Engineer.Employee
{
   public class Employee
    {
        public int ID { get; set; }
        public string? Service_number { get; set; }
        public string? Name { get; set; }
        public DateTime? YearOfBirth { get; set; }
        public DateTime? DataEmployee { get; set; }
        public DateTime? DateDismissial { get; set; }
        public int ID_Orgainzation { get; set; }
        public int ID_Division { get; set; }
        public int ID_Post { get; set; }
        public Organization Organization
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
