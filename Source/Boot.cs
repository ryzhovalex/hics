using System;

namespace Ryzhovalex.Hics {
    class Boot {
        public static void Main(string[] args) {
            TestLINQ.Run();
        }

        /// <summary>
        /// Shows that AgeChanged event correctly returns a new age set.
        /// </summary>
        private static void CallPersonEvents() {
            Person p = new Person("Jack", 21);
            int nextAge = 0;
            p.AgeChanged += new EventHandler(AgeChanged);

            while (nextAge < 100) {
                Console.WriteLine(String.Format(
                    "setting person age to <{0}>", nextAge
                ));
                p.Age = nextAge;
                nextAge++;
                Thread.Sleep(1000);
            }
        }

        private static void AgeChanged(Object sender, EventArgs args) {
            Console.WriteLine(String.Format(
                "[event] person's age is set to <{0}>", ((Person)sender).Age
            ));
        }

        private static void CallConsoleMagic() {
            ConsoleMagic.Parrot();
        }

        private static void CallQuickSort() {
            int[] numbers = {10, 98, 78, 4, 54, 25, 41, 30, 87, 60, 84, 6, 12};

            Utils.Printer.PrintArray(numbers);
            Console.WriteLine();

            QuickSort.Sort(numbers);
            Console.WriteLine();

            Utils.Printer.PrintArray(numbers);
        }
    }
}
