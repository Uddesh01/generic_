namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };

            DeleteArray deleteElement = new DeleteArray();

            Console.WriteLine("Original Int Array: " + string.Join(", ", intArray));
            intArray = deleteElement.DeleteIntMethod(4, intArray);
            Console.WriteLine("Modified Int Array: " + string.Join(", ", intArray) + "\n");

            Console.WriteLine("Original Double Array: " + string.Join(", ", doubleArray));
            doubleArray = deleteElement.DeleteDMethod(3.3, doubleArray);
            Console.WriteLine("Modified Double Array: " + string.Join(", ", doubleArray) + "\n");

            Console.WriteLine("Original Char Array: " + string.Join(", ", charArray));
            charArray = deleteElement.DeletechrMethod('c', charArray);
            Console.WriteLine("Modified Char Array: " + string.Join(", ", charArray) + "\n");

        }
    }
}