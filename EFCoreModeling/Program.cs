using EFCoreModeling.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

namespace EFCoreModeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context =new AppDbContext())
            {
                var emp1 = context.employees.Find(1);
                emp1!.FirstName = "MOhamed";
                context.SaveChanges();
            }
        }
    }
}
