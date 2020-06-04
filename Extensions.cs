// Extensions.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

    public static class Extensions
    {
        public static IEnumerable<T> InterleaveSequenceWith<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                yield return firstIter.Current;
                yield return secondIter.Current;
            }
        }

        public static IEnumerable<T> ShufflePortion<T>(this IEnumerable<T> list, int start, int end)
        {
            //Find the portion to shuffle
            var portionToShuffle = list.Skip(start).Take(end - start);

            //Shuffle the portion
            portionToShuffle = portionToShuffle.OrderBy(x => Guid.NewGuid()).ToList();

            //Reorganise so that we have (the first two)(shuffled)(tail)
            var head = list.Take(start).ToList();
            var tail = list.Skip(start + (end - start));

            //Merge them -- add the portion to shuffle followed by the tail
            head.AddRange(portionToShuffle);
            head.AddRange(tail);

            //Return head
            return head;
        }

        public static T ExtractRandom<T>(this IEnumerable<T> list)
        {
            int randIndex = new System.Random().Next(0, list.Count());

            return list.Extract(randIndex);
        }


        public static T Extract<T>(this IEnumerable<T> list, int Index)
        {
            var itemToReturn = list.ToList()[Index];

            list = list.Where(x => !x.Equals(itemToReturn));

            return itemToReturn;
        }

        public static IEnumerable<T> Draw<T>(this IEnumerable<T> list, int start, int end)
        {
            //Take out the range of things
            var itemsToReturn = list.Skip(start).Take(end - start + 1);

            //return extracted
            return itemsToReturn;
        }

    public static bool SequenceEquals<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                if (!firstIter.Current.Equals(secondIter.Current))
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<T> LogQuery<T> (this IEnumerable<T> sequence, string tag)
        {
            // File.AppendText creates a new file if the file doesn't exist.
            using (var writer = File.AppendText("debug.log"))
            {
                writer.WriteLine($"Executing Query {tag}");
            }

            return sequence;
        }

        public static IEnumerable<string> Lines(this TextReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null) yield return line;
        }

        public static IEnumerable<T> Traverse<T>(this IEnumerable<T> enumerable, Func<T, IEnumerable<T>> recursivePropertySelector)
        {
            var stack = new Stack<IEnumerable<T>>();
            stack.Push(enumerable);
            while (stack.Count != 0)
            {
                enumerable = stack.Pop();
                foreach (T item in enumerable)
                {
                    yield return item;
                    var seqRecurse = recursivePropertySelector(item);
                    if (seqRecurse != null)
                    {
                        stack.Push(seqRecurse);
                    }
                }
            }
        }
    }


