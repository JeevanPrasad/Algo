using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Core;

namespace Algo.Test
{
    [TestClass]
    public class tstLinearSearch
    {
        [TestMethod]
        public void LinearSearch_StringFound()
        {
            ISearch srch = new LinearSearch();
            
            string[] arr = new string[3] {"a","b","c" };
            string searchFor = "a";

            bool actualresult = srch.Do(arr, searchFor);
            bool expectedresult = true;

            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void LinearSearch_StringNotFound()
        {
            ISearch srch = new LinearSearch();
            
            string[] arr = new string[3] { "a", "b", "c" };
            string searchFor = "d";

            bool expectedresult = false;
            bool actualresult = srch.Do(arr, searchFor);

            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void LinearSearch_IntFound()
        {
            ISearch srch = new LinearSearch();

            int[] arr = new int[3] { 1, 2, 3};
            int searchFor = 3;

            bool actualresult = srch.Do(arr, searchFor);
            bool expectedresult = true;

            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void LinearSearch_IntNotFound()
        {
            ISearch srch = new LinearSearch();

            int[] arr = new int[3] { 1, 2, 3 };
            int searchFor = 4;

            bool expectedresult = false;
            bool actualresult = srch.Do(arr, searchFor);

            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}
