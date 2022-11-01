using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>> where T : IComparable<T> where U : IComparable<U>
    {
        T value1;
        U value2;

        T Value1 { get { return value1; } }
        U Value2 { get { return value2; } }


        public ComparablePair(T value1, U value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public int CompareTo(ComparablePair<T, U>? other)
        {

            if (value1.CompareTo(other.Value1) > 0)
            {
                return 1;
            }
            else if (value1.CompareTo(other.Value1) < 0)
            {
                return -1;
            }
            else if (value1.CompareTo(other.Value1) == 0)
            {
                if (value2.CompareTo(other.Value2) > 0)
                {
                    return 1;
                }
                else if (value2.CompareTo(other.Value2) < 0)
                {
                    return -1;
                }
                else if (value2.CompareTo(other.Value2) == 0)
                {
                    return 0;
                }
            }

            throw new Exception("Uncorrect data");
        }
    }
}
