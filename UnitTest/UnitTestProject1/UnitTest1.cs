using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RR_Game;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //defining an object with in the class GameRR 
        GameRR test1 = new GameRR();
        //first testing
        [TestMethod]
        public void positive()
        {
            //Actual - we need to provide some data to get an output
            var actual = test1.changechamper(5);
            //Assert - we need to check the output we get is correct or not
            Assert.AreEqual(expected: 6, actual);
        }
        //Second testing
        [TestMethod]
        public void Negative()
        {
            //Act - we need to provide some data to get an output
            var actual = test1.changechamper(4);
            //Assert - we need to check the output we get is correct or not
            Assert.AreNotEqual(notExpected: 3, actual);
        }
    }
}
