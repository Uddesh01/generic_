class Program
{
    static void Main(string[] args)
    {
        int[] intArray = { 1, 5, 23, 4, 2, 5 };
        double[] doubleArray = { 1.1, 54.34, 23.34, 67.44, 53.53 };
        string[] stringArray = { "ssc", "ssd", "sse", "ssz", "ssa" };

        FindMin<int> FindMin = new FindMin<int>();
        Console.WriteLine("Original Int Array: " + string.Join(", ", intArray));
        Console.WriteLine("Minimum Value:" + FindMin.Min(intArray));

        FindMin<double> FindDMin = new FindMin<double>();
        Console.WriteLine("\n" + "Original Double Array: " + string.Join(", ", doubleArray));
        Console.WriteLine("Minimum Value:" + FindDMin.Min(doubleArray));

        FindMin<string> FindStringMin = new FindMin<string>();
        Console.WriteLine("\n" + "Original Char Array: " + string.Join(", ", stringArray));
        Console.WriteLine("Minimum Value:" + FindStringMin.Min(stringArray));

    }
}