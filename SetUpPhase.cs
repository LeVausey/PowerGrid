using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using UnityEngine;
using System.Media;

public class SetUpPhase
{
    public City city;
    public Sector sector;
    //public Deck cardDeck;

    public List<Card> deck;
    public List<Card> drawedCards;

    public List<Coal> coal;
    public List<Oil> oil;
    public List<Garbage> garbage;
    public List<Nuclear> nuclear;

    public Player players;

    public void SetDeckandMarket()
    {
        //Start the deck with the default power plant cards
        deck = Deck.LoadFromFile("Assets/data/cards.dat");

        // Start of the game test
        //Shuffle first 13 cards
        deck = deck.ShufflePortion(0, 13).ToList();

        //Take one out
        Card extracted = deck.Extract(0);

        //Remove it
        deck = deck.Where(x => !x.Equals(extracted)).ToList();

        //"Extract" 8
        drawedCards = deck.Draw(0, 7).ToList();

        //Remove them
        deck = deck.Where(x => !drawedCards.Contains(x)).ToList();

        //Sort the drawed cards
        drawedCards = drawedCards.OrderBy(x => x.getFaceValue()).ToList();

        //Sort the drawed cards into current and furture market
        //drawedCards = drawedCards.SplitList; 

        //Shuffle everything in the deck
        deck = deck.ShufflePortion(0, deck.Count()).ToList();

        //Add the step card
        deck.Add(new StepThreeCard());

        //Debug.Log("Drawed cards:");

        ////Print them out to test
        foreach (var card in drawedCards)
            Debug.Log(card);

        //Debug.Log("Deck cards:");

        //////Print them out to test
        foreach (var card in deck)
            Debug.Log(card);
    }

    public void SetResourceMarket()
    {
        ////getting the coal amount 
        coal = getCoalFromFile("Assets/data/resources.dat");

        //getting the oil amount 
        oil = getOilFromFile("Assets/data/resources.dat");

        //getting the garbage amount 
        garbage = getGarbageFromFile("Assets/data/resources.dat");

        //getting the nuclear amount 
        nuclear = getNuclearFromFile("Assets/data/resources.dat");

        //var results = this.readResourceFromFile("Assets/data/resources.dat", "oil");
        foreach (var result in coal)
        {
            UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in oil)
        {
            UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in garbage)
        {
            UnityEngine.Debug.Log(result.faceValue);
        }

        foreach (var result in nuclear)
        {
            UnityEngine.Debug.Log(result.faceValue);
        }
    }   

    public void SetMapPlayerArea()
    {
        ////Set Map player area
        ////List of chosen sectors
        var chosenSectors = new List<Sector>();

        //Run through the amount of players
        for (int i = 0; i < players.Count; i++)
        {
            //Choose a sector in the chosenSectors list if its is not empty
            if (chosenSectors.Count == 0)
                chosenSectors.Add(findARandomSector());

            else
            {
                //Choose a random sector in chosen sectors
                var randomSector = chosenSectors[UnityEngine.Random.Range(0, chosenSectors.Count)];

                //Choose a random adjacent sector
                var randomAdj = randomSector.adjacentSectors[UnityEngine.Random.Range(0, chosenSectors.Count)];

                //Check here if randomAdj is in chosenSectors, if it is, then we can't start the player
                //here because its already been chosen 
                //...
                //while 
                //{

                //}

                //Otherwise;
                chosenSectors.Add(randomAdj);
            }
        }
    }

    private List<Coal> getCoalFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "coal");
        var resource = data[0];
        var cost = data[1];
        var start = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Coal(int.Parse(x), true)).ToList();
    }

    private List<Oil> getOilFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "oil");
        var resource = data[0];
        var cost = data[1];
        var start = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Oil(int.Parse(x), true)).ToList();
    }

    private List<Garbage> getGarbageFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "garbage");
        var resource = data[0];
        var cost = data[1];
        var start = int.Parse(data[2]);
        return cost.Split(',').Select(x => new Garbage(int.Parse(x), true)).ToList();
    }

    private List<Nuclear> getNuclearFromFile(string path)
    {
        var data = this.readResourceFromFile(path, "nuclear");
        var resource = data[0];
        var cost = data[1];
        var start = int.Parse(data[2]);
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
            if(chunks[0].StartsWith(key))
            {
                tempList.Add(chunks[1]);
            }
        }

        return tempList;
    }

    //private List<Coal> getCoal()
    //{
    //    List<Coal> tempList = new List<Coal>();

    //    //Add 24 coal
    //    for (decimal i = 1; i <= 24; i++)
    //    {
    //        decimal tempD = Math.Ceiling(i / 3);
    //        int tempInt = (int)tempD;
    //        tempList.Add(new Coal((int)tempD, true));
    //        //UnityEngine.Debug.Log(tempD);
    //    }
    //    //Return the list 
    //    return tempList;
    //}

    //    private List<Oil> getOil()
    //    {
    //        List<Oil> tempList = new List<Oil>();

    //        //Add 24 oil
    //        for (decimal i = 1; i <= 24; i++)
    //        {
    //            decimal tempD = Math.Ceiling(i / 3);
    //            int tempInt = (int)tempD;
    //            bool tempB;
    //            if (i < 7)
    //                tempB = false;
    //            else
    //                tempB = true;
    //            tempList.Add(new Oil((int)tempD, tempB));
    //            //UnityEngine.Debug.Log("val="+tempD+"bool:"+tempB);
    //        }

    //        //Return the list 
    //        return tempList;
    //    }

    //    private List<Garbage> getGarbage()
    //    {
    //        List<Garbage> tempList = new List<Garbage>();

    //        //Add 24 garbage
    //        for (decimal i = 1; i <= 24; i++)
    //        {
    //            decimal tempD = Math.Ceiling(i / 3);
    //            int tempInt = (int)tempD;
    //            bool tempB;
    //            if (i < 16)
    //                tempB = false;
    //            else
    //                tempB = true;
    //            tempList.Add(new Garbage((int)tempD, tempB));
    //            //UnityEngine.Debug.Log(tempD);
    //        }

    //        //Return the list 
    //        return tempList;
    //    }

    //    private List<Nuclear> getNuclear()
    //    {
    //        List<Nuclear> tempList = new List<Nuclear>();

    //        //Add 12 nuclear
    //        for (decimal i = 1; i <= 8; i++)
    //        {
    //            decimal tempD = Math.Ceiling(i / 1);
    //            int tempInt = (int)tempD;
    //            bool tempB;
    //            if (i < 8)
    //                tempB = false;
    //            else
    //                tempB = true;
    //            tempList.Add(new Nuclear((int)tempD, tempB));
    //            //UnityEngine.Debug.Log(tempD);
    //        }

    //        tempList.Add(new Nuclear(10, true));
    //        tempList.Add(new Nuclear(12, true));
    //        tempList.Add(new Nuclear(14, true));
    //        tempList.Add(new Nuclear(16, true));

    //        //Return the list 
    //        return tempList;
    //    }
}
