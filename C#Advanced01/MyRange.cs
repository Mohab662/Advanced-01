using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01
{
    internal class MyRange<T> : IComparable<MyRange<T>>
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public MyRange(int _min, int _max)
        {
            Minimum = _min;
            Maximum = _max;

        }

        public bool IsInRange(T value)
        {
            if (value is int x)
            {
                return (x.CompareTo(Minimum) >= 0) && (x.CompareTo(Maximum) <= 0);
            }

            return false;

        }

        public int Length()
        {
            return Maximum - Minimum;
        }

        public int CompareTo(MyRange<T>? myRange)
        {
            int left;
            int Right;
            if (myRange is not null)
            {
                left = this.Maximum - this.Minimum;
                Right = myRange.Maximum - myRange.Minimum;
                return left.CompareTo(Right);
            }

            return -1;
            
        }





    }
}