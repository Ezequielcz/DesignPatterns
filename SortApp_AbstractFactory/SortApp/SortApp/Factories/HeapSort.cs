using AbstractFactoryPattern;
using SortApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp.Factories
{
    public class HeapSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
    {
        public void Sort(List<T> list)
        {
            int n = list.Count;

            // Constrói a heap a partir da lista
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(list, n, i);
            }

            // Extrai repetidamente o elemento máximo da heap e o coloca no final da lista
            for (int i = n - 1; i >= 0; i--)
            {
                T temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                Heapify(list, i, 0);
            }

            Console.WriteLine("Heap Sort: " + string.Join(", ", list));
        }

        private void Heapify(List<T> list, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && list[left].CompareTo(list[largest]) > 0)
            {
                largest = left;
            }

            if (right < n && list[right].CompareTo(list[largest]) > 0)
            {
                largest = right;
            }

            if (largest != i)
            {
                T temp = list[i];
                list[i] = list[largest];
                list[largest] = temp;

                Heapify(list, n, largest);
            }
        }
    }
}
