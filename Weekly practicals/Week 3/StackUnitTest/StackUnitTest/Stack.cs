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
            String lastString;

            //Grabs the most recently added string
            lastString = Peek();

            //Delete
            if (headPointer == tailPointer)
            {
                headPointer = null;
                tailPointer = null;
            }
            else
            {
                StringNode nodeWalker = headPointer;

                while (nodeWalker.Next != tailPointer)
                    nodeWalker = nodeWalker.Next;

                if (nodeWalker.Next == tailPointer)
                {
                    nodeWalker.Next = null;
                }
             
                // Set tail to the last node, because it is now at the end      
                tailPointer = nodeWalker;
                
            }
            return lastString;
        }

        public String Peek()
        {
            String lastString;

            if (Count() == 0)
            {
                throw new Exception("Cannot peek at an empty stack");
            }

            StringNode lastNode = tailPointer;
            lastString = lastNode.Data;
            return lastString;
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
