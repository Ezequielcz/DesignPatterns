using AbstractFactoryPattern;
using SortApp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Interfaces
{
    public class IntegerSortingFactory : IAbstractSortingFactory<int>
    {
        public ISortingAlgorithm<int> CreateBubbleSort()
        {
            return new BubbleSort<int>();
        }

        public ISortingAlgorithm<int> CreateInsertionSort()
        {
            return new InsertionSort<int>();
        }

        public ISortingAlgorithm<int> CreateSelectionSort()
        {
            return new SelectionSort<int>();
        }

        public ISortingAlgorithm<int> CreateMergeSort()
        {
            return new MergeSort<int>();
        }

        public ISortingAlgorithm<int> CreateQuickSort()
        {
            return new QuickSort<int>();
        }

        public ISortingAlgorithm<int> CreateHeapSort()
        {
            return new HeapSort<int>();
        }
    }
}
