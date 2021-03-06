﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckTest : MonoBehaviour
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
        //    Debug.Log(card);


        //Debug.Log("Deck cards:");

        //////Print them out to test
        //foreach (var card in deck)
        //    Debug.Log(card);

    }

    private List<Card> getDefaultPowerPlantCards()
    {
        List<Card> tempList = new List<Card>();

        //Add 3 to 40
        //for (int i = 3; i <= 40; i++)
        //    tempList.Add(new PowerPlantCard(i));
        tempList.Add(new PowerPlantCard(3, "Oil", false, 1, 2));
        tempList.Add(new PowerPlantCard(4, "Coal", false, 1, 2));
        tempList.Add(new PowerPlantCard(5, "Oil", true, 1, 2));
        tempList.Add(new PowerPlantCard(6, "Garbage", false, 1, 1));
        tempList.Add(new PowerPlantCard(7, "Oil", false, 2, 3));
        tempList.Add(new PowerPlantCard(8, "Coal", false, 2, 3));
        tempList.Add(new PowerPlantCard(9, "Oil", false, 1, 1));
        tempList.Add(new PowerPlantCard(10, "Coal", false, 2, 2));
        tempList.Add(new PowerPlantCard(11, "Nuclear", false, 2, 1));
        tempList.Add(new PowerPlantCard(12, "Oil", true, 2, 2));
        tempList.Add(new PowerPlantCard(13, "Nothing", false, 1, 0));
        tempList.Add(new PowerPlantCard(14, "Garbage", false, 2, 2));
        tempList.Add(new PowerPlantCard(15, "Coal", false, 3, 2));
        tempList.Add(new PowerPlantCard(16, "Oil", false, 3, 2));
        tempList.Add(new PowerPlantCard(17, "Nuclear", false, 2, 1));
        tempList.Add(new PowerPlantCard(18, "Nothing", false, 2, 0));
        tempList.Add(new PowerPlantCard(19, "Garbage", false, 3, 2));
        tempList.Add(new PowerPlantCard(20, "Coal", false, 5, 3));
        tempList.Add(new PowerPlantCard(21, "Oil", true, 4, 2));
        tempList.Add(new PowerPlantCard(22, "Nothing", false, 2, 0));
        tempList.Add(new PowerPlantCard(23, "Nuclear", false, 3, 1));
        tempList.Add(new PowerPlantCard(24, "Garbage", false, 4, 2));
        tempList.Add(new PowerPlantCard(25, "Coal", false, 5, 2));
        tempList.Add(new PowerPlantCard(26, "Oil", false, 5, 2));
        tempList.Add(new PowerPlantCard(27, "Nothing", false, 3, 0));
        tempList.Add(new PowerPlantCard(28, "Nuclear", false, 4, 1));
        tempList.Add(new PowerPlantCard(29, "Oil", true, 4, 1));
        tempList.Add(new PowerPlantCard(30, "Garbage", false, 6, 3));
        tempList.Add(new PowerPlantCard(31, "Coal", false, 6, 3));
        tempList.Add(new PowerPlantCard(32, "Oil", false, 6, 3));
        tempList.Add(new PowerPlantCard(33, "Nothing", false, 4, 0));
        tempList.Add(new PowerPlantCard(34, "Nuclear", false, 5, 1));
        tempList.Add(new PowerPlantCard(35, "Oil", false, 5, 1));
        tempList.Add(new PowerPlantCard(36, "Coal", false, 7, 3));
        tempList.Add(new PowerPlantCard(37, "Nothing", false, 4, 0));
        tempList.Add(new PowerPlantCard(38, "Garbage", false, 7, 3));
        tempList.Add(new PowerPlantCard(39, "Nuclear", false, 6, 1));
        tempList.Add(new PowerPlantCard(40, "Oil", false, 6, 2));

        //Add the weird ones
        tempList.Add(new PowerPlantCard(42, "Coal", false, 6, 2));
        tempList.Add(new PowerPlantCard(44, "Nothing", false, 5, 0));
        tempList.Add(new PowerPlantCard(46, "Oil", true, 7, 3));
        tempList.Add(new PowerPlantCard(50, "Nothing", false, 6, 0));

        //Return the list 
        return tempList;
    }
}
