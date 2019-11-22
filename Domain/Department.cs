using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Department
    {
        [Column("DepartmentId")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
