namespace SimpleArray
{
    class DeleteArray
    {
        public int[] DeleteIntMethod(int elementToDelete, int[] intArray)
        {

            for (int i = 0; i < (intArray.Length - 1); i++)
            {
                if (intArray[i] == elementToDelete)
                {
                    for (int j = i; j < intArray.Length - 1; j++)
                    {
                        intArray[j] = intArray[j + 1];

                    }
                    intArray[intArray.Length - 1] = 0;
                    break;

                }

            }
            return intArray;

        }

        public double[] DeleteDMethod(Double elementToDelete, Double[] doubleArray)
        {

            for (int i = 0; i < doubleArray.Length - 1; i++)
            {
                if (doubleArray[i] == elementToDelete)
                {
                    for (int j = i; j < doubleArray.Length - 1; j++)
                    {
                        doubleArray[j] = doubleArray[j + 1];
                    }
                    doubleArray[doubleArray.Length - 1] = 0;
                    break;
                }
            }
            return doubleArray;
        }

        public char[] DeletechrMethod(char elementToDelete, char[] charArray)
        {

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                if (charArray[i] == elementToDelete)
                {
                    for (int j = i; j < charArray.Length - 1; j++)
                    {
                        charArray[j] = charArray[j + 1];
                    }
                    charArray[charArray.Length - 1] = '-';
                    break;
                }
            }
            return charArray;
        }
    }
}