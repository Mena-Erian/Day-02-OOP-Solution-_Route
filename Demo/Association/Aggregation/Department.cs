using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Aggregation
{
    // Association Relationship [Aggregation]: has a
    //                                       : Department has An Employees?
    internal class Department
    {
        public int Code { get; set; }
        public required string Name { get; set; }
        public List<Employee>? Employees { get; set; }

    }
}
