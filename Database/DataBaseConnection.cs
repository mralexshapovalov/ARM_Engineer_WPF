using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_Engineer.Models;
using System.Windows.Documents;

namespace ARM_Engineer.Database
{
    static class DataBase
    {
        static public NpgsqlConnection Connection()
        {
            string connString = "Host=localhost;Username=postgres;Password=0196;Database=ARM_Engineer";
            NpgsqlConnection newConnection = new NpgsqlConnection(connString);
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
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Organization\"", DataBase.Connection());
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

            return list;
        }

        static public Organization GetOrganizationByID(int id)
        {
            Organization org = new Organization();
            NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Organization\" Where \"ID\" = " + id, DataBase.Connection());
            NpgsqlDataReader reader = npgc.ExecuteReader();
            if (reader.HasRows)//Если пришли результаты
            {
                reader.Read();
                org.ID = reader.GetInt32(0);
                org.Name = reader.GetString(1);

            }

            return org;
        }





    }
}
