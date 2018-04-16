using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace ADS
{
    class Test
    {
        static void Main()
        {
            ADSTree t = new ADSTree();

            t.insert(43);
            t.insert(18);
            t.insert(22);
            t.insert(9);
            t.insert(21);
            t.insert(6);
            t.insert(8);
            t.insert(20);
            t.insert(63);
            t.insert(50);

            t.printTree(TraverseOrder.InOrder);
        }
    }
}