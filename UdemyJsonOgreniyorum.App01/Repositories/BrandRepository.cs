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
    internal class BrandRepository
    {
        public BrandRepository()
        {

        }
        public List<Brand> GetDataList()
        {
            List<Brand> list = new List<Brand>();
            using (var connection = new SqlConnection("data source = DESKTOP-ATHREF5; initial catalog = JsonOgreniyorum; integrated security = true"))
            {
                string query = "Select * FROM [JsonOgreniyorum].[production].[brands]";
                list = connection.Query<Brand>(query).ToList();
            }
            return list;
        }
    }
}
