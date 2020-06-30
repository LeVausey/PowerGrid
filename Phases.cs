using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phases : MonoBehaviour
{
    public int phaseNum;

    public bool phase;

    void PhaseOne()
    {
        phaseNum = 1;
        //SetPlayerOrder()

    }

    void PhaseTwo()
    {
        phaseNum = 2;
        //FirstTurnAunction()

        //Aunction()
    }

    void PhaseThree()
    {
        phaseNum = 3;
        //ChooseResources()
        //BuyResources()
    }

    void PhaseFour()
    {
        phaseNum = 4;
    }

    void PhaseFive()
    {
        phaseNum = 5;

    }
}
