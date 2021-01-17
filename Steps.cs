using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
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

    public List<BuildingSlot> buildingSlots;

    public Sector sector;

    
    public void StepOne()
    {
        step = 1;

        ////getting the coal amount 
        coal = getStepOneCoalFromFile("Assets/data/resources_step_one.dat");

        //getting the oil amount 
        oil = getStepOneOilFromFile("Assets/data/resources_step_one.dat");

        //getting the garbage amount 
        garbage = getStepOneGarbageFromFile("Assets/data/resources_step_one.dat");

        //getting the nuclear amount 
        nuclear = getStepOneNuclearFromFile("Assets/data/resources_step_one.dat");

        //var results = this.readResourceFromFile("Assets/data/resources.dat", "oil");
        foreach (var result in coal)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in oil)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in garbage)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in nuclear)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }
    }

    public void StepTwo()
    {
        step = 2;

        ////getting the coal amount 
        coal = getStepTwoCoalFromFile("Assets/data/resources_step_two.dat");

        //getting the oil amount 
        oil = getStepTwoOilFromFile("Assets/data/resources_step_two.dat");

        //getting the garbage amount 
        garbage = getStepTwoGarbageFromFile("Assets/data/resources_step_two.dat");

        //getting the nuclear amount 
        nuclear = getStepTwoNuclearFromFile("Assets/data/resources_step_two.dat");

        //var results = this.readResourceFromFile("Assets/data/resources.dat", "oil");
        foreach (var result in coal)
        {
           //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in oil)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in garbage)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in nuclear)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        //Open building slot 2
        buildingSlots.Add(new BuildingSlot(15));


        //Power Plant Market
        //drawedCards.Remove(drawedCards.Min());
    }

    public void StepThree()
    {
        step = 3;

        ////getting the coal amount 
        coal = getStepThreeCoalFromFile("Assets/data/resources_step_three.dat");

        //getting the oil amount 
        oil = getStepThreeOilFromFile("Assets/data/resources_step_three.dat");

        //getting the garbage amount 
        garbage = getStepThreeGarbageFromFile("Assets/data/resources_step_three.dat");

        //getting the nuclear amount 
        nuclear = getStepThreeNuclearFromFile("Assets/data/resources_step_three.dat");

        //var results = this.readResourceFromFile("Assets/data/resources.dat", "oil");
        foreach (var result in coal)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in oil)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in garbage)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in nuclear)
        {
            //UnityEngine.Debug.Log(result.faceValue);
        }

        //Open building slot 3
        buildingSlots.Add(new BuildingSlot(20));

        //Power Plant Market
        //drawedCards.Remove(drawedCards.Min());
    }

    //Step one resources
    private List<Coal> getStepOneCoalFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "coal");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Coal(int.Parse(x), true)).ToList();
    }

    private List<Oil> getStepOneOilFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "oil");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Oil(int.Parse(x), true)).ToList();
    }

    private List<Garbage> getStepOneGarbageFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "garbage");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Garbage(int.Parse(x), true)).ToList();
    }

    private List<Nuclear> getStepOneNuclearFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "nuclear");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Nuclear(int.Parse(x), true)).ToList();
    }

    //Step two resources
    private List<Coal> getStepTwoCoalFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "coal");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Coal(int.Parse(x), true)).ToList();
    }

    private List<Oil> getStepTwoOilFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "oil");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Oil(int.Parse(x), true)).ToList();
    }

    private List<Garbage> getStepTwoGarbageFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "garbage");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Garbage(int.Parse(x), true)).ToList();
    }

    private List<Nuclear> getStepTwoNuclearFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "nuclear");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Nuclear(int.Parse(x), true)).ToList();
    }

    //Step three resources
    private List<Coal> getStepThreeCoalFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "coal");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Coal(int.Parse(x), true)).ToList();
    }

    private List<Oil> getStepThreeOilFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "oil");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Oil(int.Parse(x), true)).ToList();
    }

    private List<Garbage> getStepThreeGarbageFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "garbage");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Garbage(int.Parse(x), true)).ToList();
    }

    private List<Nuclear> getStepThreeNuclearFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "nuclear");
        var resource = data[0];
        var cost = data[1];
        var refill = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Nuclear(int.Parse(x), true)).ToList();
    }

    private List<string> readResourceFromFile(string path, string key)
    {
        List<string> tempList = new List<string>();

        //Get the contents of the file
        var lines = File.ReadAllLines(path);

        foreach (var line in lines)
        {
            //Comment or empty, skip
            if (line.Length == 0 || line[0] == '#' || line[0] == ' ' || string.IsNullOrWhiteSpace(line))
                continue;

            //splits the line into space-delimited chunks
            var chunks = line.Split(' ');
            if (chunks[0].StartsWith(key))
            {
                tempList.Add(chunks[1]);
            }
        }

        return tempList;
    }
}

