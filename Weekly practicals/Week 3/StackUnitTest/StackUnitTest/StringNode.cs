using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTest
{
    public class StringNode
    {
        public String Data;
        public StringNode Next { get; set; }

        public StringNode(String data)
        {
            Data = data;
            Next = null;
        }
    }
}
