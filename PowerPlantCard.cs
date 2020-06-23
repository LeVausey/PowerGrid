using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PowerPlantCard : Card
{
    public int faceValue;

    public string resource;

    public bool isHybrid;

    public int powerCities;

    public int resourceRequired;

    public PowerPlantCard(int faceValue, string resource, bool isHybrid, int powerCities, int resourceRequired)
    {
        this.faceValue = faceValue;
        this.resource = resource;
        this.isHybrid = isHybrid;
        this.powerCities = powerCities;
        this.resourceRequired = resourceRequired;
    }

    public int getFaceValue()
    {
        return faceValue;
    }

    public string getResourceValue()
    {
        return null;
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

