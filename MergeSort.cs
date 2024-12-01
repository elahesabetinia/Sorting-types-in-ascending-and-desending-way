namespace SortingLibrary
{
    public class MergeSort : SortBase
    {
        public override void Sort(int[] array, bool ascending)
        {
            MergeSortHelper(array, 0, array.Length - 1, ascending);
        }

        private void MergeSortHelper(int[] array, int left, int right, bool ascending)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortHelper(array, left, mid, ascending);
                MergeSortHelper(array, mid + 1, right, ascending);
                Merge(array, left, mid, right, ascending);
            }
        }

        private void Merge(int[] array, int left, int mid, int right, bool ascending)
        {
            int[] leftArray = array[left..(mid + 1)];
            int[] rightArray = array[(mid + 1)..(right + 1)];

            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (ascending ? leftArray[i] <= rightArray[j] : leftArray[i] >= rightArray[j])
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                }
            }

            while (i < leftArray.Length) array[k++] = leftArray[i++];
            while (j < rightArray.Length) array[k++] = rightArray[j++];
        }
    }
}
