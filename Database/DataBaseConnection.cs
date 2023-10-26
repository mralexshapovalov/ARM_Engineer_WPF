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

    }
}
