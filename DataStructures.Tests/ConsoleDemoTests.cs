using DataStructures.Console.Implementation;

namespace DataStructures.Tests;

public class ConsoleDemoTests
{
    [Fact]
    public void BitArrayDemoCountsThreeSetBits()
    {
        string output = CaptureOutput(BitArrayImplementation.DisplayResult);
        Assert.Contains("Bit count: 16", output);
        Assert.Contains("Set bits (manual): 3", output);
        Assert.Contains("Set bits (PopCount): 3", output);
    }

    [Fact]
    public void MemoryDemoModifiesBufferWithoutChangingInternedStrings()
    {
        string output = CaptureOutput(Strings.DisplayMemoryStringResult);
        string[] lines = output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal(new[] { "True", "Modified String: Test Ztring", "Test string", "Test string" }, lines);
        Assert.Equal('s', lines[2][5]);
        Assert.Equal('s', lines[3][5]);
    }

    [Fact]
    public void ParsingDemoDoesNotChangeGreetingDemo()
    {
        string parsingOutput = CaptureOutput(Strings.DisplayImmutabilityResult);
        Assert.Equal(2, parsingOutput.Split("Parsed Number: 123").Length - 1);
        string greetingOutput = CaptureOutput(Strings.DisplayResult);
        Assert.Contains("Original String: Hello, World!", greetingOutput);
    }

    // Keep all tests that redirect process-wide console output in this class.
    private static string CaptureOutput(Action demo)
    {
        var original = System.Console.Out;
        using var output = new StringWriter();
        try
        {
            System.Console.SetOut(output);
            demo();
            return output.ToString();
        }
        finally
        {
            System.Console.SetOut(original);
        }
    }
}
