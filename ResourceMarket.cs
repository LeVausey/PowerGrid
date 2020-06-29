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
            tempList.Add(new Coal((int)tempD, true));
            //UnityEngine.Debug.Log(tempD);
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
            bool tempB;
            if (i < 7)
                tempB = false;
            else
                tempB = true;
            tempList.Add(new Oil((int)tempD, tempB));
            //UnityEngine.Debug.Log("val="+tempD+"bool:"+tempB);
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
            bool tempB;
            if (i < 16)
                tempB = false;
            else
                tempB = true;
            tempList.Add(new Garbage((int)tempD, tempB));
            //UnityEngine.Debug.Log(tempD);
        }

        //Return the list 
        return tempList;
    }

    private List<Nuclear> getNuclear()
    {
        List<Nuclear> tempList = new List<Nuclear>();

        //Add 12 nuclear
        for (decimal i = 1; i <= 8; i++)
        {
            decimal tempD = Math.Ceiling(i / 1);
            int tempInt = (int)tempD;
            bool tempB;
            if (i < 8)
                tempB = false;
            else
                tempB = true;
            tempList.Add(new Nuclear((int)tempD, tempB));
            //UnityEngine.Debug.Log(tempD);
        }

        tempList.Add(new Nuclear(10, true));
        tempList.Add(new Nuclear(12, true));
        tempList.Add(new Nuclear(14, true));
        tempList.Add(new Nuclear(16, true));

        //Return the list 
        return tempList;
    }
}

