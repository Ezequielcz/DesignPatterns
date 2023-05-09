using SortApp.Interfaces;
using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma fábrica de algoritmos de ordenação para números inteiros
            IAbstractSortingFactory<int> sortingFactory = new IntegerSortingFactory();

            // Cria uma lista de números inteiros para serem ordenados
            List<int> numbers = new List<int> { 5, 2, 8, 3, 1, 7 };

            // Obtém o algoritmo de ordenação Bubble Sort da fábrica e o utiliza para ordenar a lista
            ISortingAlgorithm<int> bubbleSort = sortingFactory.CreateBubbleSort();
            bubbleSort.Sort(numbers);

            ISortingAlgorithm<int>  heapSort = sortingFactory.CreateHeapSort();
            heapSort.Sort(numbers);

            ISortingAlgorithm<int> quickSort = sortingFactory.CreateQuickSort();
            quickSort.Sort(numbers);

            ISortingAlgorithm<int> selectionSort = sortingFactory.CreateSelectionSort();
            selectionSort.Sort(numbers);

            ISortingAlgorithm<int> insertionSort = sortingFactory.CreateInsertionSort();
            insertionSort.Sort(numbers);

            ISortingAlgorithm<int> mergeSort = sortingFactory.CreateMergeSort();
            mergeSort.Sort(numbers);

            Console.ReadKey();


        }
    }
}
