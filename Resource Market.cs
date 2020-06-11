using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private List<> getCoal()
    {
        List<Coal> tempList = new List<Coal>();

        //Add 28 coal
        for (int i = 1; i <= 28; i++)
            tempList.Add(new Coal(i));

        //Return the list 
        return tempList;
    }

    private List<> getOil()
    {
        List<Oil> tempList = new List<Oil>();

        //Add 28 oil
        for (int i = 1; i <= 28; i++)
            tempList.Add(new Oil(i));

        //Return the list 
        return tempList;
    }

    private List<> getGarbage()
    {
        List<Garbage> tempList = new List<Garbage>();

        //Add 28 garbage
        for (int i = 1; i <= 28; i++)
            tempList.Add(new Garbage(i));

        //Return the list 
        return tempList;
    }

    private List<> getNuclear()
    {
        List<Nuclear> tempList = new List<Nuclear>();

        //Add 12 nuclear
        for (int i = 1; i <= 12; i++)
            tempList.Add(new Nuclear(i));

        //Return the list 
        return tempList;
    }
}
