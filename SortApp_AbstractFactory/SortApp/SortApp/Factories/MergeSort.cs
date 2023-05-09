using AbstractFactoryPattern;
using SortApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Factories
{
    public class MergeSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
    {
        public void Sort(List<T> list)
        {
            if (list.Count > 1)
            {
                int middle = list.Count / 2;
                List<T> leftList = new List<T>(list.GetRange(0, middle));
                List<T> rightList = new List<T>(list.GetRange(middle, list.Count - middle));

                Sort(leftList);
                Sort(rightList);

                int leftIndex = 0;
                int rightIndex = 0;
                int mergedIndex = 0;

                while (leftIndex < leftList.Count && rightIndex < rightList.Count)
                {
                    if (leftList[leftIndex].CompareTo(rightList[rightIndex]) <= 0)
                    {
                        list[mergedIndex] = leftList[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        list[mergedIndex] = rightList[rightIndex];
                        rightIndex++;
                    }

                    mergedIndex++;
                }

                while (leftIndex < leftList.Count)
                {
                    list[mergedIndex] = leftList[leftIndex];
                    leftIndex++;
                    mergedIndex++;
                }

                while (rightIndex < rightList.Count)
                {
                    list[mergedIndex] = rightList[rightIndex];
                    rightIndex++;
                    mergedIndex++;
                }
            }

            Console.WriteLine("Merge Sort: " + string.Join(", ", list));
        }
    }
}
