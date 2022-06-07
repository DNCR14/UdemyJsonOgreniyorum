using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UdemyJsonOgreniyorum.App3.Models;

namespace UdemyJsonOgreniyorum.App3.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            List<Product> dataItemList = new List<Product>();
            using (var connection = new SqlConnection("data source = DESKTOP-ATHREF5; initial catalog = JsonOgreniyorum; integrated security = true"))
            {
                var query = @"SELECT product_id,product_name,brand_name,category_name,model_year,list_price
                from production.products as p
                inner join production.brands as b on p.brand_id = b.brand_id
                inner join production.categories as c on c.category_id = p.category_id
                order by category_name,brand_name";

                dataItemList = connection.Query<Product>(query).ToList();
            }
            return dataItemList;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            Product dataItem = new Product();

            using (var connection = new SqlConnection("data source = DESKTOP-ATHREF5; initial catalog = JsonOgreniyorum; integrated security = true"))
            {
                var query = @"SELECT product_id,product_name,brand_name,category_name,model_year,list_price
                from production.products as p
                inner join production.brands as b on p.brand_id = b.brand_id
                inner join production.categories as c on c.category_id = p.category_id
                where p.product_id = "+id.ToString();

                dataItem = connection.QueryFirstOrDefault<Product>(query);
            }

            return dataItem;
        }

    }
}
