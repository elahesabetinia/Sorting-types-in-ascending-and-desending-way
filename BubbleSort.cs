namespace SortingLibrary
{
    public class BubbleSort : SortBase
    {
        public override void Sort(int[] array, bool ascending)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (ascending ? array[j] > array[j + 1] : array[j] < array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }
    }
}
