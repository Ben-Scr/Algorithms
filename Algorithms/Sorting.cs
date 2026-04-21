
using System.Numerics;

namespace BenScr.Algorithms;

public static class Sorting
{
    /// <summary>
    /// The predicate should return true when T1 is more than T2
    /// Example use would be:
    /// Sorting.BubbleSort(values, (current, next) => { return current > next; });
    /// </summary>
    public static void BubbleSort<T>(T[] values, Func<T, T, bool> predicate)
    {
        bool hasChanged = true;

        while (hasChanged)
        {
            // Reseting bool state before entering for loop
            hasChanged = false;

            for (int i = 0; i < values.Length - 1; i++)
            {
                var current = values[i];
                var next = values[i + 1];

                if (predicate(current, next))
                {
                    values[i] = next;
                    values[i + 1] = current;

                    hasChanged = true;
                }
            }
        }
    }

    public static void BubbleSort<T>(T[] values) where T : IComparisonOperators<T, T, bool>
    {
        bool hasChanged = true;

        while (hasChanged)
        {
            // Reseting bool state before entering for loop
            hasChanged = false;

            for (int i = 0; i < values.Length - 1; i++)
            {
                var current = values[i];
                var next = values[i + 1];

                if (current > next)
                {
                    values[i] = next;
                    values[i + 1] = current;

                    hasChanged = true;
                }
            }
        }
    }

    public static void QuickSort<T>(T[] values) where T : IComparable<T>
    {
        QuickSort(values, 0, values.Length - 1);
    }

    private static void QuickSort<T>(T[] values, int left, int right) where T : IComparable<T>
    {
        if (left >= right) return;

        int pivotIndex = Partition(values, left, right);

        QuickSort(values, left, pivotIndex - 1);
        QuickSort(values, pivotIndex + 1, right);
    }

    private static int Partition<T>(T[] values, int left, int right) where T : IComparable<T>
    {
        T pivot = values[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (values[j].CompareTo(pivot) < 0)
            {
                i++;
                (values[i], values[j]) = (values[j], values[i]);
            }
        }

        (values[i + 1], values[right]) = (values[right], values[i + 1]);
        return i + 1;
    }

