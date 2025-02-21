using EFCoreModeling.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System;

namespace EFCoreModeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using(var context =new AppDbContext())
            //{
            //    var emp1 = context.employees.Find(1);
            //    emp1!.FirstName = "MOhamed";
            //    context.SaveChanges();
            //}
            using(var context =new AppDbContext())
            {
                var book1 = new Book { Title ="C++" ,authorId=1,CopyNumber=990};
                var book2 = new Book { Title ="C#" ,authorId=1,CopyNumber=70};
                var book3 = new Book { Title ="JS" ,authorId=1,CopyNumber=55};
               
                
                context.AddRange(book1, book2, book3);
                context.SaveChanges();
            }
            
        }
    }
}
