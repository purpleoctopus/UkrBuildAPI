using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkrBuildAPI.Shared.Enums;

namespace UkrBuildAPI.Shared.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EmployeePosition Position { get; set; }
    }
}
