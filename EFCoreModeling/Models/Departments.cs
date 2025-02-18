using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModeling.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string? ShortName { get; set; }
        public string? LongName { get; set; }
    }
}
