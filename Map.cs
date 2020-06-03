using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Map
{
   static void LoadInMap (string[] args)
    {
        //string filePath = @"C:\Demos\Test.txt";

        //List<string> lines = File.ReadAllLines(filePath).ToList;

        //foreach (string line in lines)
        //{
        //    Console.WriteLine(line);
        //}

        //File.WriteAllLines(filePath, lines);

        Console.ReadLine();
    }

    //public Graph (List<Connector> connectors, List<City> cities)
    //{

    //}

    static void Main(string[] args)
    {
        //Make two new sectors: illinois and california
        var illinois = new Sector("Illinois");
        var california = new Sector("California");

        //Add two cities to illinois
        //illinois.AddNode(new City("Bloomington"));
        //illinois.AddNode(new City("Chicago"));

        var cities = new List<City>();
        //var connectors = new List<Connectors>();
        var sector = new List<Sector>();
        //sectors.Add(illinois);
        //sectors.Add(california);
    }
}


