using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>   
    {
        T _Number1 { get; }
        U _Number2 { get; }


        public ComparablePair(T number1, U number2)
        {
            _Number1 = number1;
            _Number2 = number2;
        }

        public int CompareTo(ComparablePair<T, U>? other)
        {
            if (_Number1 > other._Number1)
            {
                return 1;
            }
            else if (_Number1 < other._Number1)
            {
                return -1;
            }
            else if (_Number1 == other._Number1)
            {
                if (_Number2 > other._Number2)
                {
                    return 1;
                }
                else if (_Number2 < other._Number2)
                {
                    return -1;
                }
                else if (_Number2 == other._Number2)
                {
                    return 0;
                }
            }
        }
    }
}
