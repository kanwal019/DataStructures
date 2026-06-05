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

    public static void DisplayStringArrayListResult()
    {
        ArrayList<string> words = [];
        words.Add("Hello");
        words.Add("World");
        words.Add("from");
        words.Add("CustomArrayList");
        words.Display();
        words.DisplayReverse();

        words.Set(1, "C#");
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