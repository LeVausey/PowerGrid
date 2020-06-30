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

    public int playerElektro;

    public int playerPowerPlants;

    public int playerResources;

    public int playerBuildings;
}
