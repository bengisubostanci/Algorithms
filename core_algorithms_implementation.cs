using System;

public static class SearchAlgorithms
{
    /// <summary>
    /// Sıralı bir dizide Binary Search algoritması ile arama yapar.
    /// </summary>
    /// <param name="arr">Arama yapılacak sıralı dizi</param>
    /// <param name="target">Aranan değer</param>
    /// <returns>Değer bulunduysa indeksini, bulunamadıysa -1 döner.</returns>
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Taşmayı (overflow) önlemek için

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1; // Sağ yarıya odaklan
            else
                right = mid - 1; // Sol yarıya odaklan
        }

        return -1; // Eleman bulunamadı
    }
}
