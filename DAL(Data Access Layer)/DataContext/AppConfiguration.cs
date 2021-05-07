using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layer_.DataContext
{
    class AppConfiguration
    {
        //constructor
        public AppConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();  //obtain configuration setting
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path,false);
            var root = configBuilder.Build();
            var appsetting = root.GetSection("ConnectionStrings: DefaultConnection");
            sqlconnectionString = appsetting.Value;
        }

        public string sqlconnectionString { get; set; }
    }
}
