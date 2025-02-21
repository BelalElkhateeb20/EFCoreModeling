using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModeling.Models
{
    public class Author
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }

        public string? City { get; set; } 
        public List<Book> books { get; set; } = new();
    }
}
