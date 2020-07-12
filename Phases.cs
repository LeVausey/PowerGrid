using System;
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

    public List<City> playerCities;

    public void PhaseOne() 
    {
        phaseNum = 1;
        //SetPlayerOrder()
        if (turnCounter == 1)
        {
            //rand.range;
        }

        if (turnCounter == 1)
        {
            //rand.range;
        }

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

        //choose a card
        //var randomCard = player.FindRandomCard();

        //buy card
        //player.BuyCard(randomCard);

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

        //choose a resource
        //var randomCity = player.FindRandomResource();

        //buy rescource
        //player.BuyCity(randomCity);
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

        //for (poweredplayercities = 0)
        //{
        //    // code block to be executed
        //    add.playerelektro(10)
        //}

        //for (poweredplayercities = 1)
        //{
        //    // code block to be executed
        //    add.playerelektro(22)
        //}

        //for (poweredplayercities = 2)
        //{
        //    // code block to be executed
        //    add.playerelektro(33)
        //}

        //for (poweredplayercities = 3)
        //{
        //    // code block to be executed
        //    add.playerelektro(44)
        //}

        //for (poweredplayercities = 4)
        //{
        //    // code block to be executed
        //    add.playerelektro(54)
        //}

        //for (poweredplayercities = 5)
        //{
        //    // code block to be executed
        //    add.playerelektro(64)
        //}

        //for (poweredplayercities = 6)
        //{
        //    // code block to be executed
        //    add.playerelektro(73)
        //}

        //for (poweredplayercities = 7)
        //{
        //    // code block to be executed
        //    add.playerelektro(82)
        //}

        //for (poweredplayercities = 8)
        //{
        //    // code block to be executed
        //    add.playerelektro(90)
        //}

        //for (poweredplayercities = 9)
        //{
        //    // code block to be executed
        //    add.playerelektro(98)
        //}

        //for (poweredplayercities = 10)
        //{
        //    // code block to be executed
        //    add.playerelektro(105)
        //}

        //for (poweredplayercities = 11)
        //{
        //    // code block to be executed
        //    add.playerelektro(112)
        //}

        //for (poweredplayercities = 12)
        //{
        //    // code block to be executed
        //    add.playerelektro(118)
        //}

        //for (poweredplayercities = 13)
        //{
        //    // code block to be executed
        //    add.playerelektro(124)
        //}

        //for (poweredplayercities = 14)
        //{
        //    // code block to be executed
        //    add.playerelektro(129)
        //}

        //for (poweredplayercities = 15)
        //{
        //    // code block to be executed
        //    add.playerelektro(134)
        //}

        //for (poweredplayercities = 16)
        //{
        //    // code block to be executed
        //    add.playerelektro(138)
        //}

        //for (poweredplayercities = 17)
        //{
        //    // code block to be executed
        //    add.playerelektro(142)
        //}

        //for (poweredplayercities = 18)
        //{
        //    // code block to be executed
        //    add.playerelektro(145)
        //}

        //for (poweredplayercities = 19)
        //{
        //    // code block to be executed
        //    add.playerelektro(148)
        //}

        //for (poweredplayercities = 20)
        //{
        //    // code block to be executed
        //    add.playerelektro(150)
        //}

        //restockresources
    }
}
