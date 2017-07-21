using Algo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.Test.Searches
{
    [TestClass]
    public class tstBinarySearch
    {
        [TestMethod]
        public void BinarySearch_Recursive_IntFound()
        {
            ISearch srch = new BinarySearch_Recursive();
            int[] arr = new int[3] { 1, 2, 3 };
            int searchFor = 3;

            bool expectedResult = true;
            bool actualResult = srch.Do(arr, searchFor);

            Assert.Equals(expectedResult, actualResult);
        }
    }
}
