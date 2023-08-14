using System;

namespace Slimebones.Hics {
    class Program {
        static void Main(string[] args) {
            // CallQuickSort();
            CallConsoleMagic();
        }

        static void CallConsoleMagic() {
            ConsoleMagic.Parrot();
        }

        static void CallQuickSort() {
            int[] numbers = {10, 98, 78, 4, 54, 25, 41, 30, 87, 60, 84, 6, 12};

            Utils.Printer.PrintArray(numbers);
            Console.WriteLine();

            QuickSort.Sort(numbers);
            Console.WriteLine();

            Utils.Printer.PrintArray(numbers);
        }
    }
}
