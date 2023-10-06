using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer.Database
{
    static class DataBaseConnection
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
            
        
        
            
        
    }
}
