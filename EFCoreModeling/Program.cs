using EFCoreModeling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

namespace EFCoreModeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var contect =new AppDbContext())
            {
                var emp = new Employee {  AnnualSalary = 10000, FirstName = "Belal", LastName = "Elkhateeb", IsManager = true, DepartmentId = 1 };
                var emp1 = new Employee { AnnualSalary = 2000, FirstName = "hend", LastName = "elsayed", IsManager = false, DepartmentId = 2 };
                var emp2 = new Employee { AnnualSalary = 8000, FirstName = "menna", LastName = "alaa", IsManager = true, DepartmentId = 3 };
                contect.AddRange(emp,emp1,emp2);
                contect.SaveChanges();
            }
        }
    }
}
