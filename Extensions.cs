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


    //Transitive closure
    public static IEnumerable<T> Closure<T>(T root, Func<T, IEnumerable<T>> children)
    {
        var seen = new HashSet<T>();
        var stack = new Stack<T>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            T item = stack.Pop();
            if (seen.Contains(item))
                continue;
            seen.Add(item);
            yield return item;
            foreach (var child in children(item))
                stack.Push(child);
        }
    }
}


