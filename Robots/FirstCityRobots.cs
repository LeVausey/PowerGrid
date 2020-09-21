using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// in phase 4 of the first round, 
//the robot builds his first city »last in player order« (independent of the player order). 
//The »last player« chooses this city.
public class LastChoice 
{
    /**
     * Given a player, chooses an random city connected to one
     * of their currently owned cities
    */
    public City FindRandomCity()
    {
        //Their cities
        var playerCities = this.playerBuildings;

        //Choose a random city
        var randomCity = playerCities[Random.Range(0, playerCities.Count)];

        //Choose a random out connection from this city
        var randomConnection = randomCity.connections[Random.Range(0, randomCity.connections.Count)];

        //This is the random city:
        var randomOutCity = randomConnection.outCity;

        //And return this random city:
        return randomOutCity;
    }

    /**
     * Buys a city for this player
    */
    public void BuyCity(City city)
    {
        //They have enough money to buy the city: so add it to the list of owned cities
        if (playerElektro >= city.buildingSlots[0].price)
        {
            //Add it to the list of owned cities
            playerBuildings.Add(city);

            //Deduct that amount from their money
            playerElektro -= city.buildingSlots[0].price;
        }
        else
            UnityEngine.Debug.Log("you dont have enough money!");
    }

}

public class RandomChoice
{
    /**
    * Given a player, chooses an random city connected to one
    * of their currently owned cities
   */
    public City FindRandomCity()
    {
        //Their cities
        var playerCities = this.playerBuildings;

        //Choose a random city
        var randomCity = playerCities[Random.Range(0, playerCities.Count)];

        //Choose a random out connection from this city
        var randomConnection = randomCity.connections[Random.Range(0, randomCity.connections.Count)];

        //This is the random city:
        var randomOutCity = randomConnection.outCity;

        //And return this random city:
        return randomOutCity;
    }

    /**
     * Buys a city for this player
    */
    public void BuyCity(City city)
    {
        //They have enough money to buy the city: so add it to the list of owned cities
        if (playerElektro >= city.buildingSlots[0].price)
        {
            //Add it to the list of owned cities
            playerBuildings.Add(city);

            //Deduct that amount from their money
            playerElektro -= city.buildingSlots[0].price;
        }
        else
            UnityEngine.Debug.Log("you dont have enough money!");
    }

}

public class EarlyChoice
{
    /**
    * Given a player, chooses an random city connected to one
    * of their currently owned cities
   */
    public City FindRandomCity()
    {
        //Their cities
        var playerCities = this.playerBuildings;

        //Choose a random city
        var randomCity = playerCities[Random.Range(0, playerCities.Count)];

        //Choose a random out connection from this city
        var randomConnection = randomCity.connections[Random.Range(0, randomCity.connections.Count)];

        //This is the random city:
        var randomOutCity = randomConnection.outCity;

        //And return this random city:
        return randomOutCity;
    }

    /**
     * Buys a city for this player
    */
    public void BuyCity(City city)
    {
        //They have enough money to buy the city: so add it to the list of owned cities
        if (playerElektro >= city.buildingSlots[0].price)
        {
            //Add it to the list of owned cities
            playerBuildings.Add(city);

            //Deduct that amount from their money
            playerElektro -= city.buildingSlots[0].price;
        }
        else
            UnityEngine.Debug.Log("you dont have enough money!");
    }

}

public class BiddingChoice
{
    /**
    * Given a player, chooses an random city connected to one
    * of their currently owned cities
   */
    public City FindRandomCity()
    {
        //Their cities
        var playerCities = this.playerBuildings;

        //Choose a random city
        var randomCity = playerCities[Random.Range(0, playerCities.Count)];

        //Choose a random out connection from this city
        var randomConnection = randomCity.connections[Random.Range(0, randomCity.connections.Count)];

        //This is the random city:
        var randomOutCity = randomConnection.outCity;

        //And return this random city:
        return randomOutCity;
    }

    /**
     * Buys a city for this player
    */
    public void BuyCity(City city)
    {
        //They have enough money to buy the city: so add it to the list of owned cities
        if (playerElektro >= city.buildingSlots[0].price)
        {
            //Add it to the list of owned cities
            playerBuildings.Add(city);

            //Deduct that amount from their money
            playerElektro -= city.buildingSlots[0].price;
        }
        else
            UnityEngine.Debug.Log("you dont have enough money!");
    }

}

public class DecidingChoice
{
    /**
    * Given a player, chooses an random city connected to one
    * of their currently owned cities
   */
    public City FindRandomCity()
    {
        //Their cities
        var playerCities = this.playerBuildings;

        //Choose a random city
        var randomCity = playerCities[Random.Range(0, playerCities.Count)];

        //Choose a random out connection from this city
        var randomConnection = randomCity.connections[Random.Range(0, randomCity.connections.Count)];

        //This is the random city:
        var randomOutCity = randomConnection.outCity;

        //And return this random city:
        return randomOutCity;
    }

    /**
     * Buys a city for this player
    */
    public void BuyCity(City city)
    {
        //They have enough money to buy the city: so add it to the list of owned cities
        if (playerElektro >= city.buildingSlots[0].price)
        {
            //Add it to the list of owned cities
            playerBuildings.Add(city);

            //Deduct that amount from their money
            playerElektro -= city.buildingSlots[0].price;
        }
        else
            UnityEngine.Debug.Log("you dont have enough money!");
    }

}
