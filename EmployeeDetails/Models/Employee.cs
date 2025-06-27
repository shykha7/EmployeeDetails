using System.ComponentModel.DataAnnotations;

namespace EmployeeDetails.Models
{
    public class Employee
    {
        public int Id {  get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}
