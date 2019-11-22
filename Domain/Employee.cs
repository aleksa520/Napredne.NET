using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Employee
    {
        [ForeignKey("Department")]
        public int DepId { get; set; }
        public Department Department { get; set; } = new Department();

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        [NotMapped]
        public string FullName { get; set; }
    }
}
