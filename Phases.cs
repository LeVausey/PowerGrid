using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phases 
{
    public int phaseNum;
    public bool phase;
    public bool TurnOrder = true;
    public bool ReverseTurnOrder = true;
    public int playerOrder;

    public List<Player> players = new List<Player>();

    public List<Card> deck;
    public List<Card> playerPowerPlants;

    public List<Coal> coal;
    public List<Oil> oil;
    public List<Garbage> garbage;
    public List<Nuclear> nuclear;

    public List<City> playerCities;
    public List<City> poweredPlayerCities;
    public List<City> playerCityCount = new List<City>();

    //Finding the largest city amount
    public int FindMaxValue<T>(List<T> list, Converter<T, int> projection)
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Empty list");
        }
        int maxValue = int.MinValue;
        foreach (T playerCities in list)
        {
            int value = projection(playerCities);
            if (value > maxValue)
            {
                maxValue = value;
            }
        }
        return maxValue;
    }


    public void PhaseOne() 
    {
        phaseNum = 1;

        // Find a random player order
        var randomPlayerOrder = players.Select((x, y) => y).OrderBy(x => UnityEngine.Random.value).ToArray();

        //Run through each player in this order
        for (int i = 0; i < randomPlayerOrder.Length; i++)
        {
            //Get the player by their random order
            Player player = players[randomPlayerOrder[i]];


        }

        //if (turn > 1)
        //{
        //    for (i = 0; i > player; i++)
        //    {
        //        int cityCounter = City.Count;
        //        playerCityCount.Add(cityCount);
        //    }
        //    List.Sort(playerCityCount);
        //    playerCityCount[playerCityCount.length - 1];
        //}
    }

    public void PhaseTwo()
    {
        phaseNum = 2;

        //playerOrder
        //foreach (var player in players.Reverse())
        //{
        //choose a card
        //var randomCard = player.FindRandomCard();

        //buy card
        //player.BuyCard(randomCard);
        //}

    }

    public void PhaseThree()
    {
        phaseNum = 3;

        //playerOrder.Reverse;

        //choose a resource
        //var randomCity = player.FindRandomResource();

        //buy rescource
        //player.BuyCity(randomCity);
    }

    public void PhaseFour()
    {
        phaseNum = 4;

        //playerOrder.Reverse;

        for (int i = players.Count; i > 0; i--)
        {
            //Get the player at this index
            var player = players[i];

            //Choose a random city
            var randomCity = player.FindRandomCity();

            //Buy the random city
            player.BuyCity(randomCity);
        }
    }

    public void PhaseFive()
    {
        phaseNum = 5;

        //playerOrder

        //powering cites
        //for
        //    {
        //       playerPowerPlants power playerCities
        //    }

        //foreach
        //{
                

        //}


        //for (poweredplayercities = 0)
        //{
        //    // code block to be executed
        //    add.playerelektro(10)
        //}

        //for (poweredplayercities = 1)
        //{
        //    // code block to be executed
        //    add.playerelektro(22)
        //}

        //for (poweredplayercities = 2)
        //{
        //    // code block to be executed
        //    add.playerelektro(33)
        //}

        //for (poweredplayercities = 3)
        //{
        //    // code block to be executed
        //    add.playerelektro(44)
        //}

        //for (poweredplayercities = 4)
        //{
        //    // code block to be executed
        //    add.playerelektro(54)
        //}

        //for (poweredplayercities = 5)
        //{
        //    // code block to be executed
        //    add.playerelektro(64)
        //}

        //for (poweredplayercities = 6)
        //{
        //    // code block to be executed
        //    add.playerelektro(73)
        //}

        //for (poweredplayercities = 7)
        //{
        //    // code block to be executed
        //    add.playerelektro(82)
        //}

        //for (poweredplayercities = 8)
        //{
        //    // code block to be executed
        //    add.playerelektro(90)
        //}

        //for (poweredplayercities = 9)
        //{
        //    // code block to be executed
        //    add.playerelektro(98)
        //}

        //for (poweredplayercities = 10)
        //{
        //    // code block to be executed
        //    add.playerelektro(105)
        //}

        //for (poweredplayercities = 11)
        //{
        //    // code block to be executed
        //    add.playerelektro(112)
        //}

        //for (poweredplayercities = 12)
        //{
        //    // code block to be executed
        //    add.playerelektro(118)
        //}

        //for (poweredplayercities = 13)
        //{
        //    // code block to be executed
        //    add.playerelektro(124)
        //}

        //for (poweredplayercities = 14)
        //{
        //    // code block to be executed
        //    add.playerelektro(129)
        //}

        //for (poweredplayercities = 15)
        //{
        //    // code block to be executed
        //    add.playerelektro(134)
        //}

        //for (poweredplayercities = 16)
        //{
        //    // code block to be executed
        //    add.playerelektro(138)
        //}

        //for (poweredplayercities = 17)
        //{
        //    // code block to be executed
        //    add.playerelektro(142)
        //}

        //for (poweredplayercities = 18)
        //{
        //    // code block to be executed
        //    add.playerelektro(145)
        //}

        //for (poweredplayercities = 19)
        //{
        //    // code block to be executed
        //    add.playerelektro(148)
        //}

        //for (poweredplayercities = 20)
        //{
        //    // code block to be executed
        //    add.playerelektro(150)
        //}

        //restockresources
    }
}
