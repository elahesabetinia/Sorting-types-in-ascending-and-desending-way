using SortingLibrary;
using System;

namespace SortingLibrary
{
    public class Sorter
    {
        public static void RunSorts(int[] array)
        {
            var sorters = new ICoder[]
            {
                new BubbleSort(),
                new MergeSort(),
                new SelectionSort(),
                new InsertionSort()
            };

            foreach (var sorter in sorters)
            {
                int[] ascendingArray = (int[])array.Clone();
                int[] descendingArray = (int[])array.Clone();

                Console.WriteLine($"Using {sorter.GetType().Name}:");

                sorter.Sort(ascendingArray, true);
                AnimateText.Animate("Ascending: " + string.Join(", ", ascendingArray));

                sorter.Sort(descendingArray, false);
                AnimateText.Animate("Descending: " + string.Join(", ", descendingArray));

                Console.WriteLine();
            }
        }
    }
}
