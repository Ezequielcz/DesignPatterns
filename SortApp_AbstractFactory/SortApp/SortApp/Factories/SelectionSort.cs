using AbstractFactoryPattern;
using SortApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Factories
{
    public class SelectionSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
    {
        public void Sort(List<T> list)
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (list[j].CompareTo(list[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    T temp = list[i];
                    list[i] = list[minIndex];
                    list[minIndex] = temp;
                }
            }

            Console.WriteLine("SelectionSort Sort: " + string.Join(", ", list));
        }
    }
}
