using DataStructures.Console.Extensions;
using DataStructures.Core.Arrays;

namespace DataStructures.Console.Implementation;

public class OneDimensionalArrays
{
    public static void DisplayResult()
    {
        int[] numbers = [10, 20, 30, 40, 50];
        numbers.Display();
        numbers.DisplayReverse();

        numbers[1] = 100;
        numbers.Display();
        numbers.DisplayReverse();
    }

    public static void DisplayResult2()
    {
        Array<int> numbers = new([10, 20, 30, 40, 50]);
        numbers.Display();
        numbers.DisplayReverse();

        numbers[1] = 100;
        numbers.Display();
        numbers.DisplayReverse();
    }
}
