using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Card
{
    int getFaceValue();

    string getResourceValue();

    bool isStepThree();
}
