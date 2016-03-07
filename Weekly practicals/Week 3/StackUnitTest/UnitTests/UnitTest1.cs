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
    }
}
