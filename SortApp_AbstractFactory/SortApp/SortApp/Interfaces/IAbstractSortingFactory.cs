using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Interfaces
{
    public interface IAbstractSortingFactory<T>
    {
        ISortingAlgorithm<T> CreateBubbleSort();
        ISortingAlgorithm<T> CreateInsertionSort();
        ISortingAlgorithm<T> CreateSelectionSort();
        ISortingAlgorithm<T> CreateMergeSort();
        ISortingAlgorithm<T> CreateQuickSort();
        ISortingAlgorithm<T> CreateHeapSort();
    }

}
