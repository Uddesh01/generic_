class Program
{
    static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        char[] charArray = { 'a', 'b', 'c', 'd', 'e' };

        DeleteArray deleteElement = new DeleteArray();

        Console.WriteLine("Original Int Array: " + string.Join(", ", intArray));
        deleteElement.DeleteMethod(4, intArray);


        Console.WriteLine("\n"+ "Original Double Array: " + string.Join(", ", doubleArray));
        deleteElement.DeleteMethod(3.3, doubleArray);

        Console.WriteLine("\n" + "Original Char Array: " + string.Join(", ", charArray));
        deleteElement.DeleteMethod('c', charArray);

    }
}