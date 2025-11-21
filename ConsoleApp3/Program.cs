using System;
using System.Linq;
using Xunit;

public class Program
{
    static void Main()
    {
        Console.WriteLine("программа запустилась");
    }

    [Fact]
    public void Test()
    {
        array arr = new array();
        int[] n = { 1, 2, 3, 4, 5 };
        int x = arr.arrAvg(n);
        Assert.Equal(3, x);
    }
}

public class array
{
    public int arrAvg(int[] arr) => (int)arr.Average();
}

