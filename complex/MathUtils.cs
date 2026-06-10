using System.Collections.Generic;

public static class MathUtils
{
    public static List<int> PrimeFactors(List<int> numbers)
    {
        var result = new List<int>();
        foreach (var n in numbers)
        {
            int temp = n;
            for (int i = 2; i <= temp; i++)
            {
                while (temp % i == 0)
                {
                    result.Add(i);
                    temp /= i;
                }
            }
        }
        return result;
    }
}
