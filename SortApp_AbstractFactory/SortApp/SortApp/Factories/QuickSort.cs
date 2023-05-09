using AbstractFactoryPattern;
using SortApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Factories
{
    public class QuickSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
    {
        public void Sort(List<T> list)
        {
            QuickSortHelper(list, 0, list.Count - 1);

            Console.WriteLine("Quick Sort: " + string.Join(", ", list));
        }

        private void QuickSortHelper(List<T> list, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int partitionIndex = Partition(list, leftIndex, rightIndex);

                QuickSortHelper(list, leftIndex, partitionIndex - 1);
                QuickSortHelper(list, partitionIndex + 1, rightIndex);
            }
        }

        private int Partition(List<T> list, int leftIndex, int rightIndex)
        {
            T pivot = list[rightIndex];
            int partitionIndex = leftIndex;

            for (int i = leftIndex; i < rightIndex; i++)
            {
                if (list[i].CompareTo(pivot) <= 0)
                {
                    T temp = list[i];
                    list[i] = list[partitionIndex];
                    list[partitionIndex] = temp;
                    partitionIndex++;
                }
            }

            T pivotTemp = list[rightIndex];
            list[rightIndex] = list[partitionIndex];
            list[partitionIndex] = pivotTemp;

            return partitionIndex;
        }
    }

}
