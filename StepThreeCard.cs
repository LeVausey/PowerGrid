using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StepThreeCard : Card
{
    public StepThreeCard()
    {

    }

    public int getFaceValue()
    {
        return -1;
    }

    public bool isStepThree()
    {
        return true;
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

    public override string ToString()
    {
        return $"StepThreeCard: isStepThree = {this.isStepThree()}";
    }
}

