// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


    public class TestDeck : MonoBehaviour
    {
        void Start()
        {
            // Query for building the deck
            var startingDeck = (from pp in PowerPlant().LogQuery("Power Plant generation")
                                select new { PowerPlant = pp})
                                   .LogQuery("Power Plant Deck")
                                   .ToArray();
            // Shuffling using InterleaveSequenceWith<T>();

            foreach (var c in startingDeck)
            {
                //Debug.Log(c);
            }

         

            var times = 0;
            var shuffle = startingDeck;



        {

            //Extract the portion to shuffle
            //var portionToShuffle = shuffle.Skip(2).Take(12);

            ////Shuffle them
            //portionToShuffle = portionToShuffle.OrderBy(x => Guid.NewGuid()).ToList();

            ////Reorganise so that we have (the first two)(shuffled)(tail)
            //var start = startingDeck.Take(2).ToList();
            //var tail  = startingDeck.Skip(2 + 12);

            ////Merge them -- add the portion to shuffle followed by the tail
            //start.AddRange(portionToShuffle);
            //start.AddRange(tail);



            //Shuffle the portion of the list
            var startShuffle = shuffle.ShufflePortion(0, 13);



            //Debug.Log("Before extraction: ");
            //    foreach (var c in startShuffle)
            //             Debug.Log(c + " ");


            //Get the card on top
            var extracted = startShuffle.ToList()[0];


            //Remove it
            startShuffle = startShuffle.Where(x => !x.Equals(extracted));

            //Debug.Log($"before: The size of the deck is {startShuffle.Count()}.");

            //Draw the first 8 cards
            var draw = startShuffle.Draw(0, 7);

            //Remove them from the original list
            startShuffle = startShuffle.Where(x => !draw.Contains(x));

            //foreach (var c in draw)
            //    Debug.Log(c);

            //Debug.Log($"after: The size of the deck is {startShuffle.Count()}.");


            //Shuffle the deck
            var deckShuffle = startShuffle.ShufflePortion(0, startShuffle.Count()).ToList();

            deckShuffle.Add(extracted);
            deckShuffle.Add(new { PowerPlant = "Step Three" });

            foreach (var c in deckShuffle)
                Debug.Log(c);

            //// order lowest to highest
            var ordercards = draw.OrderBy(x => x.PowerPlant);

            //foreach (var c in ordercards)
                //Debug.Log(c);


            //Debug.Log("Before final shuffle: ");
            //foreach (var c in startShuffle)
            // Debug.Log(c + " ");

            //Debug.Log("Cards Drawn: ");
            //foreach (var c in draw)
            //    Debug.Log(c + " ");

            //Debug.Log("After final shuffle: ");
            //    foreach (var c in deckShuffle)
            //        Debug.Log(c + " ");

            //Debug.Log("I chose the card " + extracted);

            //var res = from e in draw
            //        orderby e.emp_salary, e.emp_id
            //        select e;

            //foreach (var val in res)
            //{
            //    Console.WriteLine("Employee Salary: {0} Employee Id: {1}",
            //                                  val.emp_salary, val.emp_id);
            //}


            //var extractCard = startShuffle.Extract(3);


            //Shuffle the deck again
            //var deckShuffle = startShuffle.ShufflePortion(0, startShuffle.Count());


            //foreach (var c in startShuffle) 
            //{
            //    Debug.Log(c);
            //}

            //Debug.Log(extractCard +"\n\n\n\n");

            //foreach (var c in deckShuffle)
            //{
            //    Debug.Log(c);
            //}

            times++;
                //Debug.Log(times);
            } while (!startingDeck.SequenceEquals(shuffle));

            //Debug.Log(times);
        }

        static IEnumerable<string> PowerPlant()
        {
           
            yield return "03";
            yield return "04";
            yield return "05";
            yield return "06";
            yield return "07";
            yield return "08";
            yield return "09";
            yield return "10";
            yield return "11";
            yield return "12";
            yield return "13";
            yield return "14";
            yield return "15"; 
            yield return "16";
            yield return "17";
            yield return "18";
            yield return "19";
            yield return "20";
            yield return "21";
            yield return "22";
            yield return "23";
            yield return "24";
            yield return "25";
            yield return "26";
            yield return "27";
            yield return "28";
            yield return "29";
            yield return "30";
            yield return "31";
            yield return "32";
            yield return "33";
            yield return "34";
            yield return "35";
            yield return "36";
            yield return "37";
            yield return "38";
            yield return "39";
            yield return "40";
             yield return "44";
             yield return "46";
            yield return "42";
            yield return "50";
        }

        static IEnumerable<string> StepThree()
        {
        yield return "Step 3";
        }



    }

