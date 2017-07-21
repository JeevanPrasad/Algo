using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.Core
{
    public interface ISearch
    {
        bool Do(string[] arr, string searchFor);
        bool Do(int[] arr, int searchFor);
    }
}
