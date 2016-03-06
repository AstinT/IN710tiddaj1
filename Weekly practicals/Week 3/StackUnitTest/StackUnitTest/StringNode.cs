using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTest
{
    public class StringNode
    {
        public String Data;                     // Holds a string
        public StringNode Next { get; set; }    // Essential for being a node list

        // Constructor
        public StringNode(String data)
        {
            Data = data;
            Next = null;
        }
    }
}
