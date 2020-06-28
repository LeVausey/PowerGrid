using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using System.Linq;

public static class Deck 
{

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

   
}
