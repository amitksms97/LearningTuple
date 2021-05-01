using System;

namespace LearningTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple<int, String, bool> myTuple = new Tuple<int, String, bool>(1, "hello", true);

            var myTuple = Tuple.Create(1, "hello", true);

            Console.WriteLine(myTuple.Item2);
        }
    }
}
