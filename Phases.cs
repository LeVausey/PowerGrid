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

    public List<Player> players = new List<Player>();
    public List<Player> bidders;
    public List<Player> nonBidders;
    public Player playerElektro;

    public List<Card> deck;
    public List<Card> drawedCards;
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
            //bool bidButtonClicked;

            //////Number of bidders initially
            //int toBid = UnityEngine.Random.Range(0, 1);

            //if (toBid == 0)
            //{
            //    //dont bid
            //    bidButtonClicked = false;
            //}

            //if (toBid == 1)
            //{
            //    bidButtonClicked = true;
            //}

            //if (bidButtonClicked == true)
            //{
            //    //    bidders.Add(player);
            //}

            //while (bidders > 1)
            //{
                //bidders = 0;+

                //bidders money = player_money
                //if (playerElektro > base value + current_bid)
                //{
                //    //want to bid = false;
                //    //randomly choose is they still want to bid or not
                //}    

                //if (want to bid == true)
                //{
                //current_bid += incrementvalue
                //}
                //Player_Money - current_bid
                //}

                //for (i in range(0,(playerElektro)))
                //{
                ////Get the money of this player
                //money = playerElektro[i];

                ////Compute their chances
                //chance = (money - current_bid - bid_increment) / (card_price * upper_limit_factor);

                ////Roll a dice between 0 and 1 
                //diceRoll = Random.value();

                ////Is the random chance satisfied? If so, increase the bid, add to the number of bidders this round, and set last bidder
                //if diceRoll <= chance
                //{
                //current_bid += bid_increment;
                //bidders += 1;
                //last_bidder = i;
            //}

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
            //while(bool)
            //{
            //Get the player at this index
            var player = players[i];

            //Choose a random city
            var randomCity = player.FindRandomCity();

            //Buy the random city
            player.BuyCity(randomCity);
            //}
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
}
