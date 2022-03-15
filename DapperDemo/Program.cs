using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);
            var repo = new DapperProductRepository(conn);

            var products = repo.GetAllProducts();

            repo.CreateProduct("newStuff", 20.99, 1);

            foreach(var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} {prod.Name}");
            }

            /* 
             var repo = new DapperDepartmentRepository(conn);

            var departments = repo.GetAllDepartments();

            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.DepartmentID} {dept.Name}");
            }

            */
        }
    }
}
