using System;

namespace SlimeBones.Hics {
    /// <summary>
    /// Various console research.
    /// </summary>
    class ConsoleMagic {
        /// <summary>
        /// Prints colors in the center of the console window.
        /// </summary>
        public static void PrintCenteredColors() {
            ConsoleColor[] colors = {
                ConsoleColor.Blue,
                ConsoleColor.Red,
                ConsoleColor.White,
                ConsoleColor.Yellow
            };

            // clear to see first printed color correctly
            Console.Clear();

            foreach (ConsoleColor color in colors) {
                Console.CursorLeft =
                    (Console.BufferWidth - color.ToString().Length) / 2;
                Console.CursorTop =
                    (Console.BufferHeight / 2);

                Console.ForegroundColor = color;
                Console.WriteLine(color);

                Thread.Sleep(1000);

                Console.Clear();
            }
        }

        /// <summary>
        /// Echoes all input back to console.
        /// </summary>
        public static void Parrot() {
            string? message = "";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Talk to Parrot! To quit type \"q\".");
            Console.WriteLine();

            while (message != "q") {
                Console.ForegroundColor = ConsoleColor.White;
                message = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.WriteLine();
            }
        }
    }
}
