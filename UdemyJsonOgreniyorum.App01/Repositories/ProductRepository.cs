using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyJsonOgreniyorum.App01.Models;

namespace UdemyJsonOgreniyorum.App01.Repositories
{
    internal class ProductRepository
    {
        public ProductRepository()
        {

        }
        public List<Product> GetDataList()
        {
            List<Product> list = new List<Product>();
            using (var connection = new SqlConnection("data source = DESKTOP-ATHREF5; initial catalog = JsonOgreniyorum; integrated security = true"))
            {
                string query = "Select * FROM [JsonOgreniyorum].[production].[products]";
                list = connection.Query<Product>(query).ToList();
            }
            return list;
        }
    }
}
