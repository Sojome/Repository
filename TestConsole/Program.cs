using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Repository;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository Repository = new Modelo.Repository();
            var Categorias = Repository.FindEntitySet<Category>(c => true);
            /*var Category1 = Repository.Create(new Category
            {
                CategoryName="catDemos"
            });*/
            Console.Write("Presiona enter para finalizar");
            Console.ReadLine();
        }
    }
}
