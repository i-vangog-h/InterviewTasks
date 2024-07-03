using NactiData.Services;

namespace NactiDataTest;

public class OperationsTests
{
    [Fact]
    public void AddTest()
    {
        // arrange

        int a = 1;
        int b = 2;
        int c = -5;

        // act

        int expected = -2;
        int actual = Operations.Add(a, b, c);

        // assert

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void MultiplyTest()
    {
        // arrange

        int a = 1;
        int b = 2;
        int c = -5;

        // act

        int expected = -10;
        int actual = Operations.Multiply(a, b, c);

        // assert

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void AddDevideWhole()
    {
        // arrange

        int a = 1;
        int b = 2;
        int c = -5;

        // act

        Environment.SetEnvironmentVariable("WHOLE_DIVISION", "enable");
        double expected = 0;
        double actual = Operations.AddDivide(a, b, c);

        // assert

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void AddDevideDecimal()
    {
        // arrange

        int a = 1;
        int b = 2;
        int c = -5;

        // act

        Environment.SetEnvironmentVariable("WHOLE_DIVISION", "disable");
        double expected = -0.6;
        double actual = Operations.AddDivide(a, b, c);

        // assert

        Assert.Equal(expected, actual);

    }
    [Fact]
    public void AddDevideByZero()
    {
        // arrange

        int a = 1;
        int b = 2;
        int c = 0;

        // act & assert

        try
        {
            Operations.AddDivide(a, b, c);
            Assert.Fail();
        }
        catch (DivideByZeroException)
        {
            // correct exception caught
        }
        catch (Exception)
        {
            Assert.Fail();
        }
    
    }

}