namespace NactiData.Services;

public static class Operations
{
    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    public static double AddDivide(int a, int b, int c)
    {
        if (c == 0)
        {
            throw new DivideByZeroException();
        }

        if (Environment.GetEnvironmentVariable("WHOLE_DIVISION") == "disable")
        {
            return (double)(a + b) / c;
        }

        return (a + b) / c;

    }
}
