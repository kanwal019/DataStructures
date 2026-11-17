using DataStructures.Console.Extensions;
using DataStructures.Core.Arrays;

namespace DataStructures.Console.Implementation;

public class CustomArrayList
{
    public static void DisplayResult()
    {
        ArrayList<int> numbers = [with(capacity: 16)];
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }
        numbers.Display();
        numbers.DisplayReverse();

        numbers[0] = 100;
        numbers.Display();
        numbers.DisplayReverse();

        numbers.InsertAt(5, 200);
        numbers.Display();
        numbers.DisplayReverse();

        numbers.RemoveAt(2);
        numbers.Display();
        numbers.DisplayReverse();
    }

    public static void DisplayStringArrayListResult()
    {
        ArrayList<string> words = [with(capacity: 8), "Hello", "World", "from", "CustomArrayList"];
        words.Display();
        words.DisplayReverse();

        words[1] = "C#";
        words.Display();
        words.DisplayReverse();

        words.InsertAt(2, "is");
        words.Display();
        words.DisplayReverse();

        words.RemoveAt(0);
        words.Display();
        words.DisplayReverse();
    }
}
