using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class PowerPlantMarket
{
    //public static T SortCurrentMarket<T>(this IEnumerable<T> list, int start, int end)
    //{
    //    //Find the portion to shuffle
    //    var portionToShuffle = list.Skip(start).Take(end - start);

    //    //Shuffle the portion
    //    portionToShuffle = portionToShuffle.OrderBy(x => Guid.NewGuid()).ToList();
    //}

    //public static T SortFutureMarket<T>(this IEnumerable<T> list, int start, int end)
    //{
    //    //Find the portion to shuffle
    //    var portionToShuffle = list.Skip(start).Take(end - start);

    //    //Shuffle the portion
    //    portionToShuffle = portionToShuffle.OrderBy(x => Guid.NewGuid()).ToList();
    //}

    public static T Remove<T>(this IEnumerable<T> list, int Index)
    {
        var itemToReturn = list.ToList()[Index];

        list = list.Where(x => !x.Equals(itemToReturn));

        return itemToReturn;
    }

}
