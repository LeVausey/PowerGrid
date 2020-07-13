using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps
{
    public int step;

    public List<Coal> coal;
    public List<Oil> oil;
    public List<Garbage> garbage;
    public List<Nuclear> nuclear;

    public List<Card> deck;
    public List<Card> drawedCards;

    public void StepOne()
    {
        step = 1;

        //getting the coal amount 
        coal = stepOneCoal();

        //getting the oil amount 
        oil = stepOneOil();

        //getting the garbage amount 
        garbage = stepOneGarbage();

        //getting the nuclear amount 
        nuclear = stepOneNuclear();       
    }

    public void StepTwo()
    {
        step = 2;

        //getting the coal amount 
        coal = stepTwoCoal();

        //getting the oil amount 
        oil = stepTwoOil();

        //getting the garbage amount 
        garbage = stepTwoGarbage();

        //getting the nuclear amount 
        nuclear = stepTwoNuclear();

        //Open building slot 2

        //Power Plant Market
        //Card extracted = drawedCards.Extract(0);
    }

    public void StepThree()
    {
        step = 3;

        //getting the coal amount 
        coal = stepThreeCoal();

        //getting the oil amount 
        oil = stepThreeOil();

        //getting the garbage amount 
        garbage = stepThreeGarbage();

        //getting the nuclear amount 
        nuclear = stepThreeNuclear();

        //Open building slot 3

        //Power Plant Market
        //Card extracted = drawedCards.Extract(0, 1);
    }

    private List<Coal> stepOneCoal()
    {
        List<Coal> tempList = new List<Coal>();

        //Add 4 coal
        for (decimal i = 1; i <= 24; i++)
        {
            decimal tempD = Math.Ceiling(i / 3);
            int tempInt = (int)tempD;
            if (i < 4)
                tempB = false;
            else
                tempB = true;
            tempList.Add(new Coal((int)tempD, true));
            //UnityEngine.Debug.Log(tempD);
        }
        //Return the list 
        return tempList;
    }

    private List<Oil> stepOneOil()
    {
        List<Oil> tempList = new List<Oil>();

        //Add 2 oil
        for (decimal i = 1; i <= 24; i++)
        {
            decimal tempD = Math.Ceiling(i / 3);
            int tempInt = (int)tempD;
            bool tempB;
            if (i < 5)
                tempB = false;
            else
                tempB = true;
            tempList.Add(new Oil((int)tempD, tempB));
            //UnityEngine.Debug.Log("val="+tempD+"bool:"+tempB);
        }

        //Return the list 
        return tempList;
    }

    private List<Garbage> stepOneGarbage()
    {
        List<Garbage> tempList = new List<Garbage>();

        //Add 1 garbage
        for (decimal i = 1; i <= 24; i++)
        {
            decimal tempD = Math.Ceiling(i / 3);
            int tempInt = (int)tempD;
            bool tempB;
            if (i < 15)
                tempB = false;
            else
                tempB = true;
            tempList.Add(new Garbage((int)tempD, tempB));
            //UnityEngine.Debug.Log(tempD);
        }

        //Return the list 
        return tempList;
    }

    private List<Nuclear> stepOneNuclear()
    {
        List<Nuclear> tempList = new List<Nuclear>();

        //Add 1 nuclear
        for (decimal i = 1; i <= 8; i++)
        {
            decimal tempD = Math.Ceiling(i / 1);
            int tempInt = (int)tempD;
            bool tempB;
            if (i < 7)
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

    private List<Coal> stepTwoCoal()
    {
        List<Coal> tempList = new List<Coal>();

        //Add 5 coal
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

    private List<Oil> stepTwoOil()
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

    private List<Garbage> stepTwoGarbage()
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

    private List<Nuclear> stepTwoNuclear()
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

    private List<Coal> stepThreeCoal()
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

    private List<Oil> stepThreeOil()
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

    private List<Garbage> stepThreeGarbage()
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

    private List<Nuclear> stepThreeNuclear()
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

