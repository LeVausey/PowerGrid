using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class GameStart
//{
//set.playerelektro = 100
//}

//public class AlwaysLast
//{
//var lastPlayerOrder = players.Select((x, y) => y).OrderBy(x => UnityEngine.Last.value).ToArray();
//}

//public class PAYSHALFFORPOWERPLANTS
//{

/**
* Buys a card for this player
*/
//public void BuyCard(PowerPlantCard powerPlantCard)
//{
//    //They have enough money to buy the city: so add it to the list of owned cities
//    if (playerElektro >= powerPlantCard.halfFaceValue)
//    {
//        //Add it to the list of owned cards
//        playerPowerPlants.Add(powerPlantCard);

//        //Deduct that amount from their money
//        playerElektro -= powerPlantCard.faceValue;
//    }
//    else
//        UnityEngine.Debug.Log("you dont have enough money!");
//}
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
//if (playerCityAmount = 0)
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

        ////Player owned cities
        //public List<City> playerBuildings;

//     foreach (var player in players)
//        {
////Add it to the list of owned cities
//playerBuildings.Add(city);
//        }
//}

