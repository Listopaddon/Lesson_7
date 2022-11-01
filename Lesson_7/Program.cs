namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, int> value1 = new Pair<int, int>(4, 5);
            Pair<int, int> value2 = new Pair<int, int>(6, 5);
            Console.WriteLine(value1.CompareTo(value2));

        }
    }
}