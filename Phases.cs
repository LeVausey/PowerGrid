using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phases : MonoBehaviour
{
    public int phaseNum;
    public bool phase;
    public bool TurnOrder = true;
    public bool ReverseTurnOrder = true;

    void PhaseOne()
    {
        phaseNum = 1;
        //SetPlayerOrder()

    }

    void PhaseTwo()
    {
        phaseNum = 2;
        //FirstTurnAunction()
        if (TurnOrder == true)
        {
            TurnOrder = !TurnOrder;// it will take you to the next player
     
        }
        if (TurnOrder == false)
        {
            TurnOrder = !TurnOrder;// again taking to 1st player 
                        
        }

        //Aunction()       
        if (TurnOrder == true)
        {
            TurnOrder = !TurnOrder;// it will take you to the next player

        }
        if (TurnOrder == false)
        {
            TurnOrder = !TurnOrder;// again taking to 1st player 

        }

    }

    void PhaseThree()
    {
        phaseNum = 3;
        //ChooseResources()
        if (ReverseTurnOrder == true)
        {
            ReverseTurnOrder = !ReverseTurnOrder;// it will take you to the next player

        }
        if (ReverseTurnOrder == false)
        {
            ReverseTurnOrder = !ReverseTurnOrder;// again taking to 1st player 

        }

        //BuyResources()
    }

    void PhaseFour()
    {
        phaseNum = 4;

        if (ReverseTurnOrder == true)
        {
            ReverseTurnOrder = !ReverseTurnOrder;// it will take you to the next player

        }
        if (ReverseTurnOrder == false)
        {
            ReverseTurnOrder = !ReverseTurnOrder;// again taking to 1st player 

        }
    }

    void PhaseFive()
    {
        phaseNum = 5;
        if (TurnOrder == true)
        {
            TurnOrder = !TurnOrder;// it will take you to the next player

        }
        if (TurnOrder == false)
        {
            TurnOrder = !TurnOrder;// again taking to 1st player 

        }
    }
}
