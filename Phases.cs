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
            for (0, (playerElektro))
            {
                print("player %d has £%d" % (i, player_money[i]));
                print("-" * 50);
            }

            ////Number of bidders initially
            //bidders = len(player_money);

            ////How much to increment each bid by and the current bid
            //bid_increment = 100;
            //current_bid = card_price;

            ////The upper limit factor
            //upper_limit_factor = 5;

            ////Last bidder info
            //last_bidder = -1;

            //print("starting auction of %s, price is £%d" % (card_name, card_price));

            //while (bidders > 1)
            //{
            //bidders = 0;
            //for (i in range(0, len(player_money)))
            //{
            ////Get the money of this player
            //money = player_money[i];

            ////Compute their chances
            //chance = (money - current_bid - bid_increment) / (card_price * upper_limit_factor);

            ////Roll a dice between 0 and 1 (use random.value in unity)
            //    diceRoll = random.random();

            ////Is the random chance satisfied? If so, increase the bid, add to the number of bidders this round, and set last bidder
            //if diceRoll <= chance
            //{
            //current_bid += bid_increment;
            //print("[£%-4d] player %d bidded £%d (%.1f%% chance)" % (current_bid, i, bid_increment, chance * 100));
            //bidders += 1;
            //last_bidder = i;
            //}


            ////Otherwise, show that they skipped it
            //else
            //{
            //print("[£%-4d] player %d skipped (%.1f%% chance)" % (current_bid, i, chance * 100));
            //}
            //}



            //# At this point, bidders = 1 or 0 so print out information:
            //if(bidders == 0 and last_bidder == -1)
            //{
            //print("> nobody bought the card.");
            //}

            //else
            //{
            //  print("> card was bought by player %d for £%d" % (last_bidder, current_bid));
            //player_money[last_bidder] -= current_bid;
            //}

            //print("-" * 50);
            //for i in range(0, len(player_money)):

            //print("player %d has £%d" % (i, player_money[i]));
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
                ////restockresources
            }

        }
    }
}
