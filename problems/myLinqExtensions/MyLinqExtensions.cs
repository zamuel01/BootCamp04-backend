using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace System.Linq
{

    public static class MyLinqExtensions
    {
        public static IEnumerable<T> ProcessSequence<T>(this IEnumerable<T> sequence)
        {
            return sequence;
        }

        public static int? Median(this IEnumerable<int?> sequence)
        {
            var ordered = sequence.OrderBy(item => item);
            int middlePosition = ordered.Count() / 2;
            return ordered.ElementAt(middlePosition);
        }

        public static int? Median<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
            return sequence.Select(selector).Median();
        }

        public static int? Mode<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
            return sequence.Select(selector).Mode();
        }

        public static int? Mode<T>(this IEnumerable<T> sequence)
        {
            var groups = sequence.GroupBy(item => item);
            int max = -1;
            int value = 0;
            foreach(var tem in groups) {
                if (tem.Count() > max) {
                    value = Int32.Parse(tem.Key.ToString());
                    max = tem.Count();
                }
            }
            return value;
        }

        public static int? UnMode<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {
            return sequence.Select(selector).UnMode();
        }

        public static int? UnMode<T>(this IEnumerable<T> sequence)
        {
            var groups = sequence.GroupBy(item => item);
            int min = Int32.MaxValue;
            int value = 0;
            foreach(var tem in groups) {
                if (tem.Count() < min) {
                    value = Int32.Parse(tem.Key.ToString());
                    min = tem.Count();
                }
            }
            return value;
        }
    }
}