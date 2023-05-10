using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

//^^^^MUST HAVE USING DIRECTIVES^^^


namespace DapperInClass
{
    public class Program
    {
        private static IDbConnection connection;

        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            
            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperProductRepository(connection);

            repo.CreateProduct("newstuff", 20, 1);
           var products = repo.GetAllProducts();

           //foreach(var prod in products)
            {
                //Console.WriteLine($"{prod.ProductID} {prod.Name}");
            }
        }

    }
}
