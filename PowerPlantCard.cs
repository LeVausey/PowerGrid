using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PowerPlantCard : Card
{
    public int faceValue;

    public string resourceType;

    public PowerPlantCard(int faceValue, string resourceType)
    {
        this.faceValue = faceValue;
        this.resourceType = resourceType;
    }

    public int getFaceValue()
    {
        return faceValue;
    }

    public string getCoalValue()
    {
        return null;
    }

    public string getOilValue()
    {
        return null;
    }

    public string getGarbageValue()
    {
        return null;
    }

    public string getNuclearValue()
    {
        return null;
    }


    public bool isStepThree()
    {
        return false;
    }

    public override string ToString()
    {
        return $"PowerPlantCard: face value = {faceValue}, resourceType = {resourceType}, isStepThree = {this.isStepThree()}";
    }
}

