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
}

