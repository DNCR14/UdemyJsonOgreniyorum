using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyJsonOgreniyorum.App02.Models;

namespace UdemyJsonOgreniyorum.App02.Repositories
{
    internal class WebSiteRepository
    {
        public string DirectoryAddress { get; set; }
        public string JsonDatabase { get; set; }
        public WebSiteRepository()
        {
            DirectoryAddress = "C:\\WebSiteItems";
            JsonDatabase = DirectoryAddress + "\\MyPasswords.json";

            bool checkDirectory = Directory.Exists(DirectoryAddress);
            if(checkDirectory == false)
            {
                Directory.CreateDirectory(DirectoryAddress);

                bool checkDatabase = File.Exists(JsonDatabase);
                if (checkDatabase == false)
                {
                    List<WebSiteItem> databaseList = new List<WebSiteItem>();
                    databaseList.Add(new WebSiteItem
                    {
                        Id = Guid.NewGuid(),
                        WebSiteName = "https:\\www.gmail.com",
                        UserName = "dncr",
                        Password = "123456",
                        Description = "",
                        CreateDate = DateTime.Now,
                        ChangePasswordDate = DateTime.Now.AddDays(30)
                    });
                    string jsonDatabaseContent = Newtonsoft.Json.JsonConvert.SerializeObject(databaseList);
                    File.WriteAllText(JsonDatabase, jsonDatabaseContent);
                }
            }
        }
    }
}
