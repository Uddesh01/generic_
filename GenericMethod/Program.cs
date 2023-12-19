class DeleteArray
{
    public void DeleteMethod<T>(T elementToDelete, T[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {

            if (elementToDelete.Equals(inputArray[i]))
            {
                for (int j = i; j < inputArray.Length - 1; j++)
                {
                    inputArray[i] = inputArray[j + 1];
                }

                break;
            }
        }
        //return inputArray;
        Console.WriteLine("Modified Integer Array: " + string.Join(", ", inputArray));
    }
}

  



