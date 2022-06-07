using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyJsonOgreniyorum.App01.Models;
using UdemyJsonOgreniyorum.App01.Repositories;

namespace UdemyJsonOgreniyorum.App01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrandRepository brandRepository = new BrandRepository();
            List<Brand> dataListBrand = brandRepository.GetDataList();
            string jsonDataBrand = Newtonsoft.Json.JsonConvert.SerializeObject(dataListBrand);

            List<Brand> JsonDataReadBrand = JsonConvert.DeserializeObject<List<Brand>>(jsonDataBrand);

            ProductRepository productRepository = new ProductRepository();
            List<Product> dataListProduct = productRepository.GetDataList();
            string jsonDataListProduct = Newtonsoft.Json.JsonConvert.SerializeObject(dataListProduct);
            string jsonDataProduct = Newtonsoft.Json.JsonConvert.SerializeObject(dataListBrand[0]);

            Console.WriteLine(jsonDataBrand);
            Console.WriteLine(jsonDataListProduct);
            Console.WriteLine(jsonDataProduct);

            Console.ReadLine();
        }
    }
}
