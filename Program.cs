namespace SortingTechniques
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            MergeSort.printArray(arr);
            MergeSort obja = new MergeSort();
            obja.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            MergeSort.printArray(arr);

        }

    }

}