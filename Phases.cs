using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phases : MonoBehaviour
{
    public int phaseNum;
    public bool phase;
    public bool TurnOrder = true;
    public bool ReverseTurnOrder = true;
    public Player player;


    public List<Card> deck;
    public List<Card> drawedCards;

    public List<Coal> coal;
    public List<Oil> oil;
    public List<Garbage> garbage;
    public List<Nuclear> nuclear;

    public void PhaseOne() 
    {
        phaseNum = 1;
        //SetPlayerOrder()


    }

    public void PhaseTwo()
    {
        phaseNum = 2;
        ////FirstTurnAunction()
        //if (TurnOrder == true)
        //{
        //    TurnOrder = !TurnOrder;// it will take you to the next player
     
        //}
        //if (TurnOrder == false)
        //{
        //    TurnOrder = !TurnOrder;// again taking to 1st player 
                        
        //}

        ////Aunction()       
        //if (TurnOrder == true)
        //{
        //    TurnOrder = !TurnOrder;// it will take you to the next player

        //}
        //if (TurnOrder == false)
        //{
        //    TurnOrder = !TurnOrder;// again taking to 1st player 

        //}

    }

    public void PhaseThree()
    {
        phaseNum = 3;
        //ChooseResources()
        //if (ReverseTurnOrder == true)
        //{
        //    ReverseTurnOrder = !ReverseTurnOrder;// it will take you to the next player

        //}
        //if (ReverseTurnOrder == false)
        //{
        //    ReverseTurnOrder = !ReverseTurnOrder;// again taking to 1st player 

        //}

        //BuyResources()
    }

    public void PhaseFour()
    {
        phaseNum = 4;

        //buy cities

        //if (ReverseTurnOrder == true)
        //{
        //    ReverseTurnOrder = !ReverseTurnOrder;// it will take you to the next player

        //}
        //if (ReverseTurnOrder == false)
        //{
        //    ReverseTurnOrder = !ReverseTurnOrder;// again taking to 1st player 

        //}

        // Choose a random city
        var randomCity = player.FindRandomCity();

        //Buy the random city
        player.BuyCity(randomCity);

    }

    public void PhaseFive()
    {
        phaseNum = 5;
  
    }
}
