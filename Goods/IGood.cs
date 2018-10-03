using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    public interface IGood
    {
         string Category { get; set; }
         string Name { get; set; }
         int Price { get; set; }
    }
}
