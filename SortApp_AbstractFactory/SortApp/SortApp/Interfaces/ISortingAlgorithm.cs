using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Interfaces
{
    public interface ISortingAlgorithm<T>
    {
        void Sort(List<T> list);
    }
}
