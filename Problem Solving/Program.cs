using Microsoft.EntityFrameworkCore;
using Problem_Solving;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class ProblemSolving
    {
        static void Main(string[] args)
        {

            #region  Aggregate Func
            string[] MySkills = {
                "C#.net",
                "Asp.net",
                "MVC",
                "Linq",
                "EntityFramework",
                "Swagger",
                "Web-Api",
                "OrcharCMS",
                "Jquery",
                "Sqlserver",
                "Docusign"
            };
            //var commaSeperatedString = MySkills.Aggregate((s1, s2) => s1 + ", " + s2);
            //Console.WriteLine("Aggregate : " + commaSeperatedString);

            var resuls = MySkills.Aggregate((a, b) => a + " ," + b);
            Console.WriteLine("Results : " + resuls);


            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);
            ints.Add(7);
            ints.Add(8);
            ints.Add(9);
            ints.Add(10);
            ints.Add(11);
            ints.Add(12);
            ints.Add(13);
            ints.Add(14);
            ints.Add(15);

            var xyz = ints.Aggregate((a, b) => a + b);
            Console.WriteLine(xyz);
            Console.WriteLine(ints.Sum());

            #endregion


            #region Search with Paggination

            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

            using (var context = new AppDbContext(options))
            {
                // Add sample data
                var category1 = new Category { ID = 1, Name = "Electronics" };
                var category2 = new Category { ID = 2, Name = "Clothing" };
                context.Categories.AddRange(category1, category2);
                context.Products.AddRange(
                    new Product { ID = 1, Name = "Laptop", CategoryID = 1, Category = category1, IsDeleted = false },
                    new Product { ID = 2, Name = "Phone", CategoryID = 1, Category = category1, IsDeleted = false },
                    new Product { ID = 3, Name = "T-Shirt", CategoryID = 2, Category = category2, IsDeleted = false },
                    new Product { ID = 4, Name = "RTX 4070", CategoryID = 1, Category = category1, IsDeleted = false },
                    new Product { ID = 5, Name = "RX 570", CategoryID = 1, Category = category1, IsDeleted = false },
                    new Product { ID = 6, Name = "POLO T-Shirt", CategoryID = 2, Category = category2, IsDeleted = false }
                );
                context.SaveChanges();

                var repository = new ProductRepository(context);
                var result = repository.SearchWithPagination(
                    skip: 0,
                    take: 2,
                    order: "ASC",
                    predicate: x => !x.IsDeleted,
                    orderByProperty:x=>x.ID
                //predicate: p => p.CategoryID == 1,
                //predicate: x => x.Name.Contains("Phone")
                //includes: p => p.Category
                ); 
                Console.WriteLine(result);
            }
            #endregion

            Console.ReadLine();
        }
    }

}


