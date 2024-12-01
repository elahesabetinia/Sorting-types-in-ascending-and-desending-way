namespace SortingLibrary
{
    public abstract class SortBase : ICoder
    {
        public abstract void Sort(int[] array, bool ascending);
        protected void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}