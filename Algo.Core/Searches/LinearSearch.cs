using System;

namespace Algo.Core
{
    /// <summary>
    /// Linear Search
    /// Things to look for : N/A
    /// Time Complexity :  O(n)
    /// Space Complexity : O(n) 
    /// </summary>
    public class LinearSearch : ISearch
    {
        public bool Do(string[] arr, string searchFor)
        {
            for(int i=0;i< arr.Length;i++)
            {
                if (arr[i].ToLower() == searchFor.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
        public bool Do(int[] arr, int searchFor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchFor)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
