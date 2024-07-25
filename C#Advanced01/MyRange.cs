using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01
{
    internal class MyRange<T> : IComparable<MyRange<T>>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public MyRange(T _min, T _max)
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
            if (this.Maximum is int max && this.Minimum is int min)
            {
                return max - min;
            }
            else
            {
                return -1;
            }

        }

        public int CompareTo(MyRange<T>? myRange)
        {
            // Compare To do what ???!

            int left=0;
            int Right=0;
            if (this.Maximum is int max && this.Minimum is int min)
            {
                left= max - min;
            }
            if (myRange.Maximum is int maxR && myRange.Minimum is int minR)
            {
                Right = maxR - minR;
            }
            if (myRange is not null)
            {
                
                return left.CompareTo(Right);
            }

            return -1;
            
        }





    }
}