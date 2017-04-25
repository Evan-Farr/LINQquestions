using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQquestions
{
     public interface IProduct
    {
        string Name { get; set; }
        int Capacity { get; set; }
        int Stock { get; set; }
    }
}
