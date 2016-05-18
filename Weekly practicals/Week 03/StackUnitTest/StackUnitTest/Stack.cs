using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTest
{
    public class Stack
    {
        // Linked list pointers
        StringNode headPointer;
        StringNode tailPointer;

        // Constructor
        public Stack()
        {
            headPointer = null;
            tailPointer = null;
        }

        //==============================================================================
        // Add String newString on to the stack
        //==============================================================================
        public void Push(String newString)
        {
            StringNode newNode = new StringNode(newString);

            // Adding to an empty list
            if (headPointer == null)
            {
                headPointer = newNode;
                tailPointer = newNode;
            }
            else
            {
                // Adding at the end
                tailPointer.Next = newNode;
                tailPointer = newNode;
            }
        }

        //==============================================================================
        // Returns the most recently added string, and removes it from the stack
        //==============================================================================
        public String Pop()
        {
            String lastString;

            // Grabs the most recently added string
            lastString = Peek();

            /*
             * Delete
             * If you are deleting the only node in the list
             * Head and tail both become null
            */
            if (headPointer == tailPointer)
            {
                headPointer = null;
                tailPointer = null;
            }
            // Find previous and swoop
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
            // Returns lastString
            return lastString;
        }

        //==============================================================================
        // Returns the most recently added string, but does not remove it from the stack
        //==============================================================================
        public String Peek()
        {
            String lastString;

            if (Count() == 0)
            {
                // Thorws exception if stack is empty
                throw new Exception("Cannot peek at an empty stack");
            }

            // Grab last node
            StringNode lastNode = tailPointer;
            // Grab last node string
            lastString = lastNode.Data;
            // Return lastString
            return lastString;
        }

        //==============================================================================
        // Returns the number of strings currently held in the stack
        //==============================================================================
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

        //==============================================================================
        // Returns true if the stack contains zero elements and false otherwise
        //==============================================================================
        public bool IsEmpty()
        {
            if (Count() == 0)
                return true;
            else
                return false;
        }
    }
}
