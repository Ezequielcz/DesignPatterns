using AbstractFactoryPattern;
using SortApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Factories
{
    public class BubbleSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
    {
        public void Sort(List<T> list)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        T temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine("Bubble Sort: " + string.Join(", ", list));
        }
    }
}
