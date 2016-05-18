using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            // adding to an empty list
            if (headPointer == null)
            {
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else
            {
                // adding at the end
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            int count = 0;
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                nodeWalker.Move();
                nodeWalker = nodeWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                if (nodeWalker.TestOutOfBounds(boundsRectangle))
                {
                    nodeWalker.IsAlive = false;
                }
                nodeWalker = nodeWalker.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            // If you are deleting the first node
            if (pelletToDelete == headPointer)
            {
                // If it is the only node in the list
                // Head and tails both become null
                if ((pelletToDelete == headPointer) && (pelletToDelete == tailPointer))
                {
                    headPointer = null;
                    tailPointer = null;

                }
                // Move head along to the second node
                else
                {
                    headPointer = pelletToDelete.Next;
                }
            }
            // Find previous and swoop
            else
            {
                Pellet nodeWalker = headPointer;

                while (nodeWalker.Next != pelletToDelete)
                    nodeWalker = nodeWalker.Next;

                if (nodeWalker.Next == pelletToDelete)
                {
                    nodeWalker.Next = pelletToDelete.Next;
                }                

                // If you have just deleted the last node in the list
                // Set tail to the previous node, because it is now at the end
                if (tailPointer == pelletToDelete)
                {
                    tailPointer = nodeWalker;
                }
            }
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                if (nodeWalker.IsAlive == false)
                {
                    DeleteOne(nodeWalker);
                }
                nodeWalker = nodeWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                nodeWalker.Draw();
                nodeWalker = nodeWalker.Next;
            }
        }
    }
}
