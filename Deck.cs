﻿using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using System.Linq;
using System.Diagnostics;

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

    public static IEnumerable<T> LogQuery<T>(this IEnumerable<T> sequence, string tag)
    {
        // File.AppendText creates a new file if the file doesn't exist.
        using (var writer = File.AppendText("debug.log"))
        {
            writer.WriteLine($"Executing Query {tag}");
        }

        return sequence;
    }

    //public static IEnumerable<List<T>> SplitList<T>(this IEnumerable<T> list, int nSize = 4)
    //{
    //    for (int i = 0; i < list.Count; i += nSize)
    //    {
    //        yield return locations.GetRange(i, Math.Min(nSize, list.Count - i));
    //    }
    //}

    public static List<Card> LoadFromFile(string path)
    {
            List<Card> tempList = new List<Card>();

            //Get the contents of the file
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                //Comment or empty, skip
                if (line.Length == 0 || line[0] == '#' || line[0] == ' ' || string.IsNullOrWhiteSpace(line))
                    continue;

                //splits the line into space-delimited chunks
                var chunks = line.Split(' ');
                //UnityEngine.Debug.Log(chunks[0]);

                var faceValue = int.Parse(chunks[0].Replace(":",""));
                var resource = chunks[1].Replace(",", "");
                bool isHybrid = bool.Parse(chunks[2].Replace(",", ""));
                var powerCities = int.Parse(chunks[3].Replace(",", ""));
                var resourceRequired = int.Parse(chunks[4].Replace(",", ""));

                var card = new PowerPlantCard(faceValue, resource, isHybrid, powerCities, resourceRequired);

                tempList.Add(card);
            }

            return tempList;
    }
}
