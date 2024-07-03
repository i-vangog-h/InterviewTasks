using static NactiData.Services.Operations;
using static NactiData.Display.ConsoleDisplay;

namespace NactiData;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Count() != 3)
        {
            throw new Exception("Incorrect input: exactly 3 numbers are expected.");
        }

        int[] numbers = new int[3];

        for (int i = 0; i <= 2; i++)
        {
            if (!Int32.TryParse(args[i], out numbers[i]))
            {
                throw new FormatException($"Incorrect input at position {i}: got \'{args[i]}\', Int32 number is expected");
            }
        }

        Console.Write("Enable whole division (Y/n): ");

        Environment.SetEnvironmentVariable(
            "WHOLE_DIVISION",
            Console.ReadLine() == "n" ? "disable" : "enable"
        );


        int a = numbers[0];
        int b = numbers[1];
        int c = numbers[2];

        OutputAdd(Add(a, b, c).ToString());

        OutputMultiply(Multiply(a, b, c).ToString());

        try
        {
            OutputAddDivide(AddDivide(a, b, c).ToString());
        }
        catch (DivideByZeroException)
        {
            OutputAddDivide("unable to devide by zero");
        }
    }
}
