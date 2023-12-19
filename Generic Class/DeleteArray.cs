class DeleteArray<T>
{
    public void DeleteMethod(T elementToDelete, T[] inputArray)
    {
        for (int i = 0; i < inputArray.Length-1; i++)
        {
            if (elementToDelete.Equals(inputArray[i]))
            {
                for (int j = i; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }
                inputArray[inputArray.Length - 1] = default;
                break;
            }
        }
      //return inputArray;
        Console.WriteLine("Modified Int Array: " + string.Join(", ", inputArray) + "\n");
    }
}


