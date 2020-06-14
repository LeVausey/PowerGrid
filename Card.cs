using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Card
{
    int getFaceValue();

    string getCoalValue();

    string getOilValue();

    string getGarbageValue();

    string getNuclearValue();

    bool isStepThree();
}
