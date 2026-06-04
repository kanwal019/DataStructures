using DataStructures.Console.Extensions;
using DataStructures.Core.Arrays;

namespace DataStructures.Console.Implementation;

public class CustomArrayList
{
    public static void DisplayResult()
    {
        ArrayList<int> numbers = [];
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }
        numbers.Display();
        numbers.DisplayReverse();

        numbers.Set(0, 100);
        numbers.Display();
        numbers.DisplayReverse();

        numbers.InsertAt(5, 200);
        numbers.Display();
        numbers.DisplayReverse();

        numbers.RemoveAt(2);
        numbers.Display();
        numbers.DisplayReverse();
    }
}