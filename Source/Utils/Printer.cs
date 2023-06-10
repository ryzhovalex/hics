namespace Slimebones.Hics.Utils {
    public static class Printer {
        public static void PrintArray(int[] array) {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void PrintArray(string[] array) {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
