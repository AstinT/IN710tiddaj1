using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackUnitTest;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // Test 1
        [TestMethod]
        public void IsEmpty_NewStack_ReturnsTrue()
        {
            Stack stack = new Stack();
            
            bool expected = true;
            bool actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
   
        // Test 2
        [TestMethod]
        public void Push_NewStackAddOneItem_ReturnsAddedString()
        {
            Stack stack = new Stack();
            
            //Adding string
            stack.Push("Dog");

            String expected = "Dog";
            String actual = stack.Peek();

            Assert.AreEqual(expected, actual);
        }

         // Test 3
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Pop_NewStack_ThrowException()
        {
            Stack stack = new Stack();
            stack.Pop();
        }

        // Test 4
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Peek_NewStack_ThrowException()
        {
            Stack stack = new Stack();
            stack.Peek();
        }
    }
}
