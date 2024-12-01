namespace SortingLibrary
{
    public class SelectionSort : SortBase
    {
        public override void Sort(int[] array, bool ascending)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minOrMaxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (ascending ? array[j] < array[minOrMaxIndex] : array[j] > array[minOrMaxIndex])
                    {
                        minOrMaxIndex = j;
                    }
                }
                Swap(array, i, minOrMaxIndex);
            }
        }
    }
}
