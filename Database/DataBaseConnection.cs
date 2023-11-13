using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_Engineer.Models;
using System.Windows.Documents;
using ARM_Engineer.Technic;

namespace ARM_Engineer.Database
{
    static class DataBase
    {
        public static NpgsqlConnection newConnection;
        static public NpgsqlConnection Connection()
        {

            string connString = "Host=localhost;Username=postgres;Password=0196;Database=ARM_Engineer";
            newConnection = new NpgsqlConnection(connString);
            try
            {
                //Открываем соединение.
                newConnection.Open();
            }
            catch (Exception ex)
            {
                //Код обработки ошибок
            }
            return newConnection;
        }



        static public List<Organization> GetAllOrganizations()
        {
            List<Organization> list = new List<Organization>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Organization\"", newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Organization());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);
                }
            }
            reader.Close();

            return list;
        }

        static public Organization GetOrganizationByID(int id)
        {
            Organization org = new Organization();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Organization\" Where \"ID\" = " + id, newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                reader.Read();
                org.ID = reader.GetInt32(0);
                org.Name = reader.GetString(1);
            }
            reader.Close();
            return org;
        }

        static public List<Division> GetAllDivision()
        {
            List<Division> list = new List<Division>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Division\"", newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Division());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);
                }
            }
            reader.Close();
            return list;
        }

        static public Division GetDivisionByID(int id)
        {
            Division division = new Division();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Division\" Where \"id\" = " + id, newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                reader.Read();
                division.ID = reader.GetInt32(0);
                division.Name = reader.GetString(1);

            }
            reader.Close();
            return division;
        }

        static public List<Post> GetAllPost()
        {
            List<Post> list = new List<Post>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Post\"", newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new Post());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);
                }
            }
            reader.Close();
            return list;
        }

        static public Post GetPostByID(int id)
        {
            Post post = new Post();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Post\" Where \"id\" = " + id, newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                reader.Read();
                post.ID = reader.GetInt32(0);
                post.Name = reader.GetString(1);

            }
            reader.Close();
            return post;
        }

        static public List<ClassObjectOperation> GetAllClassObjectOperation()
        {
            List<ClassObjectOperation> list = new List<ClassObjectOperation>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Class_object_operation\"", newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new ClassObjectOperation());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);
                }
            }
            reader.Close();
            return list;
        }

        static public ClassObjectOperation GetClassObjectOperationByID(int id)
        {
            ClassObjectOperation classObjectOperation = new ClassObjectOperation();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Class_object_operation\" Where \"id\" = " + id, newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                reader.Read();
                classObjectOperation.ID = reader.GetInt32(0);
                classObjectOperation.Name = reader.GetString(1);

            }
            reader.Close();
            return classObjectOperation;
        }

        static public List<BrandEquipment> GetAllBrandEquipment()
        {
            List<BrandEquipment> list = new List<BrandEquipment>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Brand_equipment\"", newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new BrandEquipment());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);
                }
            }
            reader.Close();
            return list;
        }

        static public BrandEquipment GetBrandEquipmentByID(int id)
        {
            BrandEquipment brandEquipment = new BrandEquipment();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Brand_equipment\" Where \"id\" = " + id, newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                reader.Read();
                brandEquipment.ID = reader.GetInt32(0);
                brandEquipment.Name = reader.GetString(1);

            }
            reader.Close();
            return brandEquipment;
        }

        static public List<VehicleManagementCategory> GetAllVehicleManagementCategory()
        {
            List<VehicleManagementCategory> list = new List<VehicleManagementCategory>();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Vehicle_management_category\"", newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                while (reader.Read())//Считывает строчку
                {
                    list.Add(new VehicleManagementCategory());
                    list.Last().ID = reader.GetInt32(0);
                    list.Last().Name = reader.GetString(1);
                }
            }
            reader.Close();
            return list;
        }

        static public VehicleManagementCategory GetVehicleManagementCategoryByID(int id)
        {
            VehicleManagementCategory vehicleManagementCategory = new VehicleManagementCategory();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Vehicle_management_category\" Where \"id\" = " + id, newConnection);
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                reader.Read();
                vehicleManagementCategory.ID = reader.GetInt32(0);
                vehicleManagementCategory.Name = reader.GetString(1);

            }
            reader.Close();
            return vehicleManagementCategory;
        }

    }
}
