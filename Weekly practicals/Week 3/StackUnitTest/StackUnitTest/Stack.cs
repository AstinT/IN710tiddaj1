using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTest
{
    public class Stack
    {
        StringNode headPointer;
        StringNode tailPointer;

        public Stack()
        {
            headPointer = null;
            tailPointer = null;
        }

        public void Push(String newString)
        {
            StringNode newNode = new StringNode(newString);

            // adding to an empty list
            if (headPointer == null)
            {
                headPointer = newNode;
                tailPointer = newNode;
            }
            else
            {
                // adding at the end
                tailPointer.Next = newNode;
                tailPointer = newNode;
            }
        }

        public String Pop()
        {

        }

        public String Peek()
        {

        }

        public int Count()
        {
            int count = 0;
            StringNode nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }
            return count;
        }

        public bool IsEmpty()
        {
            if (Count() == 0)
                return true;
            else
                return false;
        }
    }
}
