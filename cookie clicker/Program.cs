namespace cookie_clicker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int money = 0;

            Console.WriteLine("Press E!");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        money++;
                    }
                }

                Console.SetCursorPosition(15, 15);
                Console.WriteLine(money);

            }
        }
    }
}