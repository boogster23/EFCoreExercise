using DbScaffolding.Models;
using System;

namespace EFCoreExercise.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            DbEfCoreContext context = new DbEfCoreContext();
            context.Departments.Add(new Departments
            {
                Capacity = 100,
                DeptName = "Electronics",
                Location = "Manila",
                DeptNo = 1
            });

            context.SaveChanges();
        }
    }
}
