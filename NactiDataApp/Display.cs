namespace NactiData.Display
{
    public static class ConsoleDisplay
    {
        public static void OutputAdd(string result)
        {
            Console.WriteLine($"Sum of three numbers: {result}");
        }

        public static void OutputMultiply(string result)
        {
            Console.WriteLine($"Product of three numbers: {result}");
        }

        public static void OutputAddDivide(string result)
        {
            Console.WriteLine($"Sum of first two numbers devided by the third: {result}");
        }
    }
}
