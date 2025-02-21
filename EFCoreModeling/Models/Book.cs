using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModeling.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int CopyNumber { get; set; }
        public int authorId { get; set; }
        public Author author { get; set; } = new();
    }
}
