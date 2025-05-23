using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstWebMVC.Models
{
    public class Employee : Person
    {   
        public required string EmployeeId { get; set; }
        public required int Age { get; set; }
    }
}
