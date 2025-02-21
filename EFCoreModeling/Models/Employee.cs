using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModeling.Models
{
    public class Employee
    {
        //[Column("EmployeeID")]//mapping in DB Name
        public int Id { get; set; }
        //[MaxLength(200)]
        public string? FirstName { get; set; }
        //[Column(TypeName="varchar(200)")]//mapping The type in DB
        public string? LastName { get; set; }
        //[Length(5,2)]
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        //[Comment("the DepatmentID  ")]
        public int DepartmentId { get; set; }
        public string? FullName { get; set; }

    }
}
