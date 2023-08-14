namespace Slimebones.Hics {
    public static class QuickSort {
        /// <summary>
        /// Sorts the array using Quick Sort method.
        /// </summary>
        /// <remarks>
        /// The array given is altered in place.
        /// </remarks>
        /// <param name="numbers">array to sort</param>
        public static void Sort(int[] numbers) {
            SortLR(numbers, 0, numbers.Length - 1);
        }

        private static void SortLR(
            int[] numbers,
            int leftIndex,
            int rightIndex
        ) {
            int i = leftIndex;
            int j = rightIndex;
            int x = numbers[(i + j) / 2];

            // move from left to center and from right to center placing
            // lower values to the left side and higher values to the right
            do {
                while (numbers[i] < x) {
                    i++;
                }
                while (numbers[j] > x) {
                    j--;
                }

                if (i <= j) {
                    int y = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = y;
                    i++;
                    j--;
                }
            } while (i < j);

            if (leftIndex < j) {
                SortLR(numbers, leftIndex, j);
            }
            if (leftIndex < rightIndex) {
                SortLR(numbers, i, rightIndex);
            }
        }
    }
}
