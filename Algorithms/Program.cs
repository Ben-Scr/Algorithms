using BenScr.Security;

using BenScr.Algorithms;
using BenScr.Security.Cryptography;

public static class Program
{
    public static void Main(string[] args)
    {
        RandomSecure rand = new RandomSecure();
        byte[] values = new byte[255];
        rand.GenerateBytes(values);

        Console.WriteLine("Hello World!");
        char[] word = { 'H', 'E', 'L', 'L', 'O', 'A', '1', '3', '2' };

        WriteArray(values);

        Console.WriteLine("\n------------------------");

        Sorting.QuickSort(values);

        WriteArray(values);
    }

    public static void WriteArray<T>(T[] arr)
    {
        string s = "[ ";

        for(int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
                s += arr[i];
            else
                s += ", " + arr[i];
        }

        s += " ]";

        Console.WriteLine(s);
    }
}