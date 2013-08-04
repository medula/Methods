using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using 04.CountsNumberAppear;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr ={1,2,3,4,5,6,7,8,9,0,11,12,13,
                         6,7,8,9,10,11,12,13,14,15,16,17,17,
                         11,12,13,14,15,16,17,11,10,9,8,7,25,
                         19,20,21,23,25,16,17,18,23,18,19,20,21,
                         22,23,16,17,18,12,14,16,9,8,7,6,7};


            int res = CountTimesAppear.CountNumbers(arr, 16);
            Assert.AreEqual(5, res);
        }
    }
}
