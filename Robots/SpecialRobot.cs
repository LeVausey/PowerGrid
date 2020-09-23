using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class GameStart
//{
 
//}

//public class AlwaysLast
//{

//}

//public class PAYSHALFFORPOWERPLANTS
//{

//}

//public class ALLCITIESCOSTTEN
//{
//    /**
//    * Given a player, chooses an random city connected to one
//    * of their currently owned cities
//   */
//    public City FindRandomCity()
//    {
//        //Their cities
//        var playerCities = this.playerBuildings;

//        //Choose a random city
//        var randomCity = playerCities[Random.Range(0, playerCities.Count)];

//        //Choose a random out connection from this city
//        var randomConnection = randomCity.connections[Random.Range(0, randomCity.connections.Count)];

//        //This is the random city:
//        var randomOutCity = randomConnection.outCity;

//        //And return this random city:
//        return randomOutCity;
//    }

//    /**
//     * Buys a city for this player
//    */
//    public void BuyCity(City city)
//    {
//        //They have enough money to buy the city: so add it to the list of owned cities
//        if (playerElektro >= city.buildingSlots[0].price)
//        {
//            //Add it to the list of owned cities
//            playerBuildings.Add(city);

//            //Deduct that amount from their money
//            playerElektro -= city.buildingSlots[0].price;
//        }
//        else
//            UnityEngine.Debug.Log("you dont have enough money!");
//    }

//}

//public class ALWAYSBUILDSFIRSTCITYFORZERO
//{
//    /**
//    * Given a player, chooses an random city connected to one
//    * of their currently owned cities
//   */
//    public City FindRandomCity()
//    {
//        //Their cities
//        var playerCities = this.playerBuildings;

//        //Choose a random city
//        var randomCity = playerCities[Random.Range(0, playerCities.Count)];

//        //Choose a random out connection from this city
//        var randomConnection = randomCity.connections[Random.Range(0, randomCity.connections.Count)];

//        //This is the random city:
//        var randomOutCity = randomConnection.outCity;

//        //And return this random city:
//        return randomOutCity;
//    }

//    /**
//     * Buys a city for this player
//    */
//    public void BuyCity(City city)
//    {
//        //They have enough money to buy the city: so add it to the list of owned cities
//        if (playerElektro >= city.buildingSlots[0].price)
//        {
//            //Add it to the list of owned cities
//            playerBuildings.Add(city);

//            //Deduct that amount from their money
//            playerElektro -= city.buildingSlots[0].price;
//        }
//        else
//            UnityEngine.Debug.Log("you dont have enough money!");
//    }

//}

//public class GETSINCOME
//{
//     foreach (var player in players)
//        {
//            drawedCards.Remove(drawedCards.Min());
//            drawedCards = deck.Draw(0, 0).ToList();

//            //powering cites
//            foreach (var city in playerCities)
//            {
               
//                //var powerCity = player.PowerCity();

//                //PowerCity(powerCity) = player.PowerCity(poweredplayercities);
               
//                //for (poweredplayercities = 0)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(10)
//                //}

//                //for (poweredplayercities = 1)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(22)
//                //    }

//                //for (poweredplayercities = 2)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(33)
//                //    }

//                //for (poweredplayercities = 3)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(44)
//                //    }

//                //for (poweredplayercities = 4)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(54)
//                //    }

//                //for (poweredplayercities = 5)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(64)
//                //    }

//                //for (poweredplayercities = 6)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(73)
//                //    }

//                //for (poweredplayercities = 7)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(82)
//                //    }

//                //for (poweredplayercities = 8)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(90)
//                //    }

//                //for (poweredplayercities = 9)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(98)
//                //    }

//                //for (poweredplayercities = 10)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(105)
//                //    }

//                //for (poweredplayercities = 11)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(112)
//                //    }

//                //for (poweredplayercities = 12)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(118)
//                //    }

//                //for (poweredplayercities = 13)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(124)
//                //    }

//                //for (poweredplayercities = 14)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(129)
//                //    }

//                //for (poweredplayercities = 15)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(134)
//                //    }

//                //for (poweredplayercities = 16)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(138)
//                //    }

//                //for (poweredplayercities = 17)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(142)
//                //    }

//                //for (poweredplayercities = 18)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(145)
//                //    }

//                //for (poweredplayercities = 19)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(148)
//                //    }

//                //for (poweredplayercities = 20)
//                //{
//                //    // code block to be executed
//                //    add.playerelektro(150)
//                //}
//            }

//        }
//}

