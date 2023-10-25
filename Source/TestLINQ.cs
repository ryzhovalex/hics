namespace Ryzhovalex.Hics
{
    public static class TestLINQ
    {
        public static void Run()
        {
            List<int> numbers = new List<int> {1, 2, 3, 4};

            var results =
                from n in numbers
                where n > 2
                select n * 2;

            foreach (var n in results)
            {
                Console.WriteLine(n);
            }
        }
    }
}
