using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using System.Linq;

public class Deck : MonoBehaviour
{
    public List<Card> cards;
    public List<Card> deck;
    public List<Card> drawedCards;

    void Start()
    {
        //Start the deck with the default power plant cards
        deck = new Card("Deck", "Assets/data/cards.dat");

        // Start of the game test
        //Shuffle first 13 cards
        deck = deck.ShufflePortion(0, 13).ToList();
         
        //Take one out
        Card extracted = deck.Extract(0);

        //Remove it
        deck = deck.Where(x => !x.Equals(extracted)).ToList();

        //"Extract" 8
        drawedCards = deck.Draw(0, 7).ToList();

        //Remove them
        deck = deck.Where(x => !drawedCards.Contains(x)).ToList();

        //Sort the drawed cards
        drawedCards = drawedCards.OrderBy(x => x.getFaceValue()).ToList();

        //Shuffle everything in the deck
        deck = deck.ShufflePortion(0, deck.Count()).ToList();

        //Add the step card
        deck.Add(new StepThreeCard());

        // Step 2 test
        //Shuffle everything in the deck
        //deck = deck.ShufflePortion(0, deck.Count()).ToList();

        //"Draw" 8
        //drawedCards = deck.Draw(0, 7).ToList();

        //Sort the drawed cards
        //drawedCards = drawedCards.OrderBy(x => x.getFaceValue()).ToList();

        //Add the step card
        //deck.Add(new StepThreeCard());


        // Step 3 test
        //Shuffle everything in the deck
        //deck = deck.ShufflePortion(0, deck.Count()).ToList();

        //"Draw" 8
        //drawedCards = deck.Draw(0, 5).ToList();

        //Sort the drawed cards
        //drawedCards = drawedCards.OrderBy(x => x.getFaceValue()).ToList();

        //Debug.Log("Drawed cards:");

        //////Print them out to test
        //foreach (var card in drawedCards)
        //      Debug.Log(card);


        //Debug.Log("Deck cards:");

        //////Print them out to test
        //foreach (var card in deck)
        //     Debug.Log(card);

        //string path = @"C:\Users\Jacob\Documents\Masters\MyTest.txt";
        //if (!File.Exists(path))
        //{
        //    // Create a file to write to.
        //    using (StreamWriter sw = File.CreateText(path))
        //    {
                
        //    }
        //}

        //// Open the file to read from.
        //using (StreamReader sr = File.OpenText(path))
        //{
        //    string s;
        //    while ((s = sr.ReadLine()) != null)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

    }

    public Deck(string name, string cardsFile)
    {
        //Set the name
        this.name = name;

        //Load in sectors data.
        this.cards = this.ParseCardsFromFile(cardsFile);
    }

    private List<Card> ParseCardsFromFile(string filename)
    {
        List<Card> tempList = new List<Card>();

        //Get the contents of the file
        var lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            //Comment or empty, skip
            if (line.Length == 0 || line[0] == '#' || line[0] == ' ' || string.IsNullOrWhiteSpace(line))
                continue;

            //splits the line into space-delimited chunks
            var chunks = line.Split(' ');

            var faceValue = chunks[0];
            var resource = chunks[1].Replace(":", "");
            var isHybrid = chunks[2].Replace(":", "");
            var powerCities = chunks[3].Replace(":", "");
            var resourceRequired = chunks[4].Replace(":", "");

            var card = new Card(faceValue, resource, isHybrid, powerCities, resourceRequired);

            tempList.Add(card);
        }

        return tempList;
    }   

            ////Add 3 to 40
            //for (int i = 3; i <= 40; i++)
            //    tempList.Add(new PowerPlantCard(i));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));

            ////Add the weird ones
            //tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
            //tempList.Add(new PowerPlantCard(44, "n/a", false, 5, 0));
            //tempList.Add(new PowerPlantCard(46, "Oil", true, 7, 3));  
            //tempList.Add(new PowerPlantCard(50, "n/a", false, 6, 0));

   

   
}
