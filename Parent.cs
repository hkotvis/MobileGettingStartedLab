using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface Parent
    {
        string Name { get; set; }
        int Age { get; set; }
        int Id { get; set; }
        enum Program { Computer Science; Accounting, Nursing}
    }
}
