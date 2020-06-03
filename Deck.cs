using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using System.Linq;

public class Deck : MonoBehaviour
{

    public List<Card> deck;
    public List<Card> drawedCards;

    void Start()
    {
        //Start the deck with the default power plant cards
        deck = getDefaultPowerPlantCards();


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
        //       Debug.Log(card);


        //Debug.Log("Deck cards:");

        //////Print them out to test
        //foreach (var card in deck)
        //   Debug.Log(card);

        string path = @"C:\Users\Jacob\Documents\Masters\MyTest.txt";
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

    }

    private List<Card> getDefaultPowerPlantCards()
    {
        List<Card> tempList = new List<Card>();

        //Add 3 to 40
        for (int i = 3; i <= 40; i++)
            tempList.Add(new PowerPlantCard(i));

        //Add the weird ones
        tempList.Add(new PowerPlantCard(42));
        tempList.Add(new PowerPlantCard(44));
        tempList.Add(new PowerPlantCard(46));  
        tempList.Add(new PowerPlantCard(50));

        //Return the list 
        return tempList;
    }

   
}
