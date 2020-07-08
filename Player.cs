using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerNumber; // To set whether it's player 1 or 2

    //if(gM.turn == playerNumber - 1) // -1 because computers count from zero. 
    //{   
    // // do player's turn actions
    //gM.changeTurn();
    //}
    

    //Player owned Resources
    public List<Coal> playerCoal;
    public List<Oil> playerOil;
    public List<Garbage> playerGarbage;
    public List<Nuclear> playerNuclear;

    //Player Elektro 
    public int playerElektro = 50;

    //Player owned power plant cards
    public List<Card> playerPowerPlants;

    //Player owned cities
    public List<City> playerBuildings;

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
            Debug.Log("you dont have enough money!");
    }
}

