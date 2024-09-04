namespace DynamicProgramming;

public class MagicIndex
{
    public static int FindMagicIndexBruteForce(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == i)
            {
                return i;
            }
        }

        return -1;
    }

    public static int FindMagicIndexBinariSearch(int[] array)
    {
        return BinarySearch(array, 0, array.Length - 1);

        static int BinarySearch(int[] a, int start, int end)
        {
            if (start > end) return -1;
            int mid = (start + end) / 2;
            if (a[mid] == mid)
            {
                return mid;
            }
            else if (a[mid] < mid)
            {
                return BinarySearch(a, mid+1, end);
            }
            else
            {
                return BinarySearch(a, start, mid-1);
            }
        }
    }

    public static int FindMagicIndexBinariSearchHandleDuplicates(int[] array)
    {
        return BinarySearch(array, 0, array.Length - 1);

        static int BinarySearch(int[] a, int start, int end)
        {
            if (start > end) return -1;
            int mid = (start + end) / 2;
            if (a[mid] == mid)
            {
                return mid;
            }
            
            // search right
            var rightIndex = Math.Max(a[mid], mid+1);
            var right = BinarySearch(a, rightIndex, end);
            if (right >= 0)
            {
                return right;
            }

            // serch left
            var leftIndex = Math.Min(a[mid], mid-1);
            var left = BinarySearch(a, start, leftIndex);
            
            return left;
        }
    }
}