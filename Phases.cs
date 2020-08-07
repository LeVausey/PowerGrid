 
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Media;

public class Phases 
{
    public int phaseNum;
    public bool phase;
    public int playerOrder;
    public int turn = 0;
    public int i;
    public bool bidButtonClicked;
    public bool bid;

    public int current_bid;
    public int price_increment;
    public int biddableCount = 4;
    public Player player;

    public List<Player> players = new List<Player>();
    public List<Player> bidders;
    public List<Player> nonBidders;
    public List<Card> deck;
    public List<Card> drawedCards;
    public List<Card> chosenCard;
    public List<Card> playerPowerPlant;

    public int playerElektro;
    public PowerPlantCard selectedPlant = null;
    public int currentBid;

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

            turn++;
        }

        if (turn > 1)
        {
            //for (i = 0; i > player; i++)
            //{
            //    int cityCounter = City.Count;
            //    playerCityCount.Add(cityCount);
            //}
            //List.Sort(playerCityCount);
            //playerCityCount[playerCityCount.length - 1];
        }
    }

    
    public void PhaseTwo()
    {
        phaseNum = 2;

        //playerOrder
        foreach (var player in players)
        {
            SetSelectedPlant();

            if (selectedPlant == null)
                return;
            if (selectedPlant.purchased)//can't purchase already purchased plant
                return;
            if (p.cash < currentBid)
                return;
            if (p.powerPlants.Count >= maxPowerPlants)
                return;

            ////Number of bidders initially
            int toBid = UnityEngine.Random.Range(0, 1);

            if (toBid == 0)
            {
                //dont bid
                bidButtonClicked = false;
            }

            if (toBid == 1)
            {
                bidButtonClicked = true;
            }

            if (bidButtonClicked == true)
            {
                bidders.Add(player);
            }


            //setting the range of the Elektro
            foreach (int value in Enumerable.Range(0, (playerElektro)))
            {
                //Get the money of this player
                var money = playerElektro[i];

                //the bidding
                while (toBid == 1 && playerElektro < current_bid + price_increment)
                {
                    //player bids w.e you want to do here probs players_money - current_bid + increment
                    toBid = UnityEngine.Random.Range(0, 1);

                    if (bidders.count == 1)
                    {
                        //bidders.element(player) buys card

                        player.BuyCard();
                        drawedCards = deck.Draw(0).ToList();
                    }
                }
            }
        }  
    }


    public void PhaseThree()
    {
        phaseNum = 3;

        //playerOrder.Reverse;
        //for (int i = players.Count; i > 0; i--)
        //{
        //while(bool)
        //{
        //    //Get the player at this index
        //    var player = players[i];

        //    //Choose a random resource
        //    var randomResource = player.FindRandomResource();

        //    //Buy the random resource
        //    player.BuyResource(randomResource);
        //}
        //}
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
        foreach (var player in players)
        {
            drawedCards.Remove(drawedCards.Min());
            drawedCards = deck.Draw(0, 0).ToList();

            //powering cites
            foreach (var city in playerCities)
            {
               
                //var powerCity = player.PowerCity();

                //PowerCity(powerCity) = player.PowerCity(poweredplayercities);
               
                //for (poweredplayercities = 0)
                //{
                //    // code block to be executed
                //    add.playerelektro(10)
                //}

                //for (poweredplayercities = 1)
                //{
                //    // code block to be executed
                //    add.playerelektro(22)
                //    }

                //for (poweredplayercities = 2)
                //{
                //    // code block to be executed
                //    add.playerelektro(33)
                //    }

                //for (poweredplayercities = 3)
                //{
                //    // code block to be executed
                //    add.playerelektro(44)
                //    }

                //for (poweredplayercities = 4)
                //{
                //    // code block to be executed
                //    add.playerelektro(54)
                //    }

                //for (poweredplayercities = 5)
                //{
                //    // code block to be executed
                //    add.playerelektro(64)
                //    }

                //for (poweredplayercities = 6)
                //{
                //    // code block to be executed
                //    add.playerelektro(73)
                //    }

                //for (poweredplayercities = 7)
                //{
                //    // code block to be executed
                //    add.playerelektro(82)
                //    }

                //for (poweredplayercities = 8)
                //{
                //    // code block to be executed
                //    add.playerelektro(90)
                //    }

                //for (poweredplayercities = 9)
                //{
                //    // code block to be executed
                //    add.playerelektro(98)
                //    }

                //for (poweredplayercities = 10)
                //{
                //    // code block to be executed
                //    add.playerelektro(105)
                //    }

                //for (poweredplayercities = 11)
                //{
                //    // code block to be executed
                //    add.playerelektro(112)
                //    }

                //for (poweredplayercities = 12)
                //{
                //    // code block to be executed
                //    add.playerelektro(118)
                //    }

                //for (poweredplayercities = 13)
                //{
                //    // code block to be executed
                //    add.playerelektro(124)
                //    }

                //for (poweredplayercities = 14)
                //{
                //    // code block to be executed
                //    add.playerelektro(129)
                //    }

                //for (poweredplayercities = 15)
                //{
                //    // code block to be executed
                //    add.playerelektro(134)
                //    }

                //for (poweredplayercities = 16)
                //{
                //    // code block to be executed
                //    add.playerelektro(138)
                //    }

                //for (poweredplayercities = 17)
                //{
                //    // code block to be executed
                //    add.playerelektro(142)
                //    }

                //for (poweredplayercities = 18)
                //{
                //    // code block to be executed
                //    add.playerelektro(145)
                //    }

                //for (poweredplayercities = 19)
                //{
                //    // code block to be executed
                //    add.playerelektro(148)
                //    }

                //for (poweredplayercities = 20)
                //{
                //    // code block to be executed
                //    add.playerelektro(150)
                //}
            }

        }
    }

    public void SetSelectedPlant(PowerPlantCard p)
    {


        bool isBiddable = true;
        for (int i = biddableCount; i < drawedCards.Count; i++)
        {
            if (((PowerPlantCard)drawedCards[i]) == p)
            {
                isBiddable = false;
                break;
            }
        }

        if (!isBiddable)
            return;

        selectedPlant = p;
        currentBid = p.faceValue;
    }

}
