using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class PowerPlantMarket
{
    public static T Remove<T>(this IEnumerable<T> list, int Index)
    {
        var itemToReturn = list.ToList()[Index];

        list = list.Where(x => !x.Equals(itemToReturn));

        return itemToReturn;
    }

}
