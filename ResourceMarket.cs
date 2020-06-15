using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using System.Linq;

public class ResourceMarket : MonoBehaviour
{
    public List<Coal> coal;
    public List<Oil> oil;
    public List<Garbage> garbage;
    public List<Nuclear> nuclear;

    void Start()
    {
        //getting the coal amount 
        coal = getCoal();

        //getting the oil amount 
        oil = getOil();

        //getting the garbage amount 
        garbage = getGarbage();

        //getting the nuclear amount 
        nuclear = getNuclear();



    }

    private List<Coal> getCoal()
    {
        List<Coal> tempList = new List<Coal>();

        //Add 24 coal
        for (decimal i = 1; i <= 24; i++)
        {
            decimal tempD = Math.Ceiling(i / 3);
            int tempInt = (int)tempD;
            tempList.Add(new Coal((int)tempD));
        }
        //Return the list 
        return tempList;
    }

    private List<Oil> getOil()
    {
        List<Oil> tempList = new List<Oil>();

        //Add 24 oil
        for (decimal i = 1; i <= 24; i++)
        {
            decimal tempD = Math.Ceiling(i / 3);
            int tempInt = (int)tempD;
            tempList.Add(new Coal((int)tempD));
        }

        //Return the list 
        return tempList;
    }

    private List<Garbage> getGarbage()
    {
        List<Garbage> tempList = new List<Garbage>();

        //Add 24 garbage
        for (decimal i = 1; i <= 24; i++)
        {
            decimal tempD = Math.Ceiling(i / 3);
            int tempInt = (int)tempD;
            tempList.Add(new Coal((int)tempD));
        }

        //Return the list 
        return tempList;
    }

    private List<Nuclear> getNuclear()
    {
        List<Nuclear> tempList = new List<Nuclear>();

        //Add 12 nuclear
        for (decimal i = 1; i <= 24; i++)
        {
            decimal tempD = Math.Ceiling(i / 3);
            int tempInt = (int)tempD;
            tempList.Add(new Coal((int)tempD));
        }

        //Return the list 
        return tempList;
    }
}

