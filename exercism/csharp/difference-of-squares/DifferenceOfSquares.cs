using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for (int j = 1; j <= max; j++) {
            sum += j;
        }
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;   
        for (int i = 1; i <= max; i++) {
            sum += i*i;
        }
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}