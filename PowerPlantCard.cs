using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PowerPlantCard : Card
{
    public int faceValue;

    public PowerPlantCard(int faceValue)
    {
        this.faceValue = faceValue;
    }

    public int getFaceValue()
    {
        return faceValue;
    }

    public bool isStepThree()
    {
        return false;
    }

    public override string ToString()
    {
        return $"PowerPlantCard: face value = {faceValue}, isStepThree = {this.isStepThree()}";
    }
}

