using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources 
{
    public Coal coal;

    public Oil oil;

    public Garbage garbage;

    public Nuclear nuclear;
  
}

public class Coal
{
    public int faceValue { get; set; }
    public bool available { get; set;}

    public Coal(int faceValue, bool available)
    {
        this.faceValue = faceValue;
        this.available = available;
    }
}

public class Oil
{
    public int faceValue { get; set; }
    public bool available { get; set; }

    public Oil(int faceValue, bool available)
    {
        this.faceValue = faceValue;
        this.available = available;
    }
}

public class Garbage 
{
    public int faceValue { get; set; }
    public bool available { get; set; }

    public Garbage(int faceValue, bool available)
    {
        this.faceValue = faceValue;
        this.available = available;
    }
}

public class Nuclear
{
    public int faceValue { get; set; }
    public bool available { get; set; }

    public Nuclear(int faceValue, bool available)
    {
        this.faceValue = faceValue;
        this.available = available;
    }
}

