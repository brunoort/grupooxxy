using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoWeb.Core
{
    public class DBService
    {
        private static string connectionString = "mongodb://localhost";

        public MongoDatabase GetDatabase()
        {
            try
            {                
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("Veiculos");
                
                return database;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar no banco" + ex.Message);
            }
        }
        
    }
}
