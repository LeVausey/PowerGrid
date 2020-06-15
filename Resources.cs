using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources 
{
  
}

public class Coal
{
    public int faceValue { get; set; }
    public bool availible { get; set;}

    public Coal(int faceValue)
    {
        this.faceValue = faceValue;
    }
}

public class Oil 
{
    public int faceValue;

    public Oil(int faceValue)
    {
        this.faceValue = faceValue;
    }
}

public class Garbage 
{
    public int faceValue;

    public Garbage(int faceValue)
    {
        this.faceValue = faceValue;
    }
}

public class Nuclear
{
    public int faceValue;

    public Nuclear(int faceValue)
    {
        this.faceValue = faceValue;
    }
}

