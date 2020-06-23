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

    public string getResourceValue()
    {
        return null;
    }


    public override string ToString()
    {
        return $"StepThreeCard: isStepThree = {this.isStepThree()}";
    }
}

