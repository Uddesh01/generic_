using System.Collections;

class FindMin<T> where T: IComparable<T>
{
    public T Min ( T[] inputArray)
    {
        T MinValue = inputArray[0];
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (MinValue.CompareTo(inputArray[i])>0)
            {
                MinValue = inputArray[i];
            }

        }
        //Console.WriteLine("Minimum Value:"+MinValue);
        return MinValue;
    }
}
