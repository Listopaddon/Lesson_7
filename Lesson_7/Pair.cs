using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class Pair<T, U> : ComparablePair<T, U> where T : IComparable<T> where U : IComparable<U>
    {
        T value1;
        U value2;

        public T Value1
        { get { return value1; } }

        public U Value2
        { get { return value2; } }

        public Pair(T value1, U value2) : base(value1, value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public void OutputValues()
        {
            Console.WriteLine($"your first value is {value1}");
            Console.WriteLine($"your second value is {value2}");
        }
    }
}
