using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public int playerNumber; 
    

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
    * choose a random card for this player
    */
    //public Card FindRandomCard()
    //{
    //    //Their cards
    //    var playerCards = this.playerPowerPlants;

    //    //Choose a random card
    //    var randomCard = playerPowerPlants[Random.Range(0, playerCards.Count)];

    //    //And return this random card:
    //    return randomCard;
    //}

    /**
    * Buys a card for this player
    */
    public void BuyCard(PowerPlantCard powerPlantCard)
    {
        //They have enough money to buy the city: so add it to the list of owned cities
        if (playerElektro >= powerPlantCard.faceValue)
        {
            //Add it to the list of owned cards
            playerPowerPlants.Add(powerPlantCard);

            //Deduct that amount from their money
            playerElektro -= powerPlantCard.faceValue;
        }
        else
            Debug.Log("you dont have enough money!");
    }


    /**
    * choose a random resource for this player
    */
    //public Resources ResourceFindRandom()
    //{
        ////Their resources
        //var playerResource = this.playerCoal;
        //var playerResource = this.playerOil;
        //var playerResource = this.playerGarbage;
        //var playerResource = this.playerNuclear;

        ////Choose a random card
        //var randomResource = playerResource[Random.Range(0, playerResource.Count)];

        ////And return this random card:
        //return randomResource;
    //}

    /**
    * Buys a resource for this player
    */
    public void BuyResource(Resources resource)
    {
        //They have enough money to buy the city: so add it to the list of owned cities
        //if (playerElektro >= resource.price)
        //{
        //    //Add it to the list of owned cities
        //    playerCoal.Add(resource);
        //    playerOil.Add(resource);
        //    playerGarbage.Add(resource);
        //    playerNuclear.Add(resource);

        //    //Deduct that amount from their money
        //    playerElektro -= resource.price;
        //}
        //else
        //    Debug.Log("you dont have enough money!");
    }

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

