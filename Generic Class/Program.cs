class Program   
{
    static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        char[] charArray = { 'a', 'b', 'c', 'd', 'e' };

        DeleteArray<int> deleteIntElement = new DeleteArray<int>();
        Console.WriteLine("Original Int Array: " + string.Join(", ", intArray));
        deleteIntElement.DeleteMethod(4, intArray);

        DeleteArray<double> deleteDElement = new DeleteArray<double>();
        Console.WriteLine("\n" + "Original Double Array: " + string.Join(", ", doubleArray));
        deleteDElement.DeleteMethod(3.3, doubleArray);

        DeleteArray<char> deleteCharElement = new DeleteArray<char>();
        Console.WriteLine("\n" + "Original Char Array: " + string.Join(", ", charArray));
        deleteCharElement.DeleteMethod('c', charArray);

    }
}