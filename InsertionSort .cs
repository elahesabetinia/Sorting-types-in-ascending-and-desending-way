namespace SortingLibrary
{
    public class InsertionSort : SortBase
    {
        public override void Sort(int[] array, bool ascending)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && (ascending ? array[j] > key : array[j] < key))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
