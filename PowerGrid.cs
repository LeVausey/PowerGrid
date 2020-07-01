using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGrid : MonoBehaviour
{
    public GameObject[] players;
    public int turn = 0;
    public int playerAmount = 0;
    public int playerOrder = 0;
    public int phase = 1;
    public int step = 1;

    // Start is called before the first frame update
    void Start()
    {
        SetUpPhase setUp = gameObject.GetComponent<SetUpPhase>();

        setUp.SetDeckandMarket();
        setUp.SetFirstTurnPlayerOrder();
        setUp.SetPlayerElektro();
        setUp.SetMapPlayerArea();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    public void changeTurn()
    {
        if (turn < players.Length)
        {
            turn++;
        }
        else
        {
            turn = 0;
        }
    }
}

public class playerData
{

}

public class turnNum
{

}

public class PhaseLoop
{

}

public class StepLoop
{

}

public class EndGame
{

}

public class Logger
{

}