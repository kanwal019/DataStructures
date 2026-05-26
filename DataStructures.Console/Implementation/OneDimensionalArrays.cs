using DataStructures.Core.Arrays;

namespace DataStructures.Console.Implementation;

public class OneDimensionalArrays
{
    public static void DisplayResult()
    {
        Array<int> numbers = new(5);

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        numbers.Display();
        numbers.DisplayReverse();

        numbers[1] = 100;
        numbers.Display();
        numbers.DisplayReverse();
    }
}
