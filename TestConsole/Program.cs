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
            //IRepository Repository = new Modelo.Repository();
            IUnitOfWork Repository = new Modelo.RepositoryUoW();
            //Omitir para que salga
            //var Categorias = Repository.FindEntitySet<Category>(c => true);

            //******************* Crear *******************
            /*var Category1 = Repository.Create(new Category
            {
                CategoryName="catDemosEE"
            });*/

            /*var customer1 = Repository.Create(new Customer 
            {
                CustomerID = "PuceB",
                CompanyName= "PUCESEEE"
            });*/

            //******************* Borrar *******************
            //var cust = Repository.Delete(new Category { CategoryID = 13 });

            /*var Categoryremove = Repository.FindEntity<Category>(c => c.CategoryID == 14);
            Repository.Delete(Categoryremove);*/

            //******************* Actualizar *******************
            //var up = Repository.Update(new Category { CategoryID =16, CategoryName="TERE" });

            /*var UpdateID = Repository.FindEntity<Category>(p => p.CategoryID == 15);
            UpdateID.CategoryName = "Pepas";
            UpdateID.Description = "Esta feo";
            Repository.Update(UpdateID);*/

            //******************* Leer *******************
            /*var mos = Repository.FindEntity<Category>(a => a.CategoryID == 16);
            Console.WriteLine(mos.CategoryName);*/

            var Changes = Repository.Save();

            Console.Write("Presiona enter para finalizar");
            Console.ReadLine();
        }
    }
}
