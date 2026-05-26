using DataStructures.Console.Extensions;

namespace DataStructures.Console.Implementation;

public class MultiDimensionalArrays
{
    public static void DisplayResult()
    {
        int[,] numbers = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        numbers.Display();
        numbers.DisplayMetadata();

        numbers[0, 0] = 10;
        numbers.Display();
    }

    public static void DisplayJaggedArrayResult()
    {
        int[][] numbers =
            [
                [1, 2, 3],
                [10, 20, 30, 40, 50],
                [5, 6]
            ];
        numbers.Display();
        numbers.DisplayMetadata();

        numbers[0][0] = 100;
        numbers.Display();
    }
}
