using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Repository;
using System.Data.Entity;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository Repository = new Modelo.Repository();
            //IUnitOfWork Repository = new Modelo.RepositoryUoW();
            var Categorias = Repository.FindEntitySet<Category>(c => true);

            var Category1 = Repository.Create(new Category
            {
                CategoryName="catDemosD"
            });

            var customer1 = Repository.Create(new Customer 
            {
                CustomerID = "PuceA",
                CompanyName= "PUCESEB"
            });

            //var Changes = Repository.Save();

            Console.Write("Presiona enter para finalizar");
            Console.ReadLine();
        }
    }
}
