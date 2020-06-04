using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Map : MonoBehaviour
{
    void Start()
    {
        string filePath = @"C:\Users\Jacob\Documents\Masters\PowerGrid\PowerGrid\Assets\Scripts\Test.txt";

        List<City> cities = new List<City>();

        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            string[] entries = line.Split(',');

            City newCity = new City();

            newCity.CityName = entries[0];
            newCity.SectorName = entries[1];

            cities.Add(newCity);
        }

        foreach (var city in cities)
            Debug.Log($"{city.CityName} {city.SectorName}");

        Console.ReadLine();
    }

    //public Map(){
    //    Cities = new List<City>();
    //    Connectors = new List<Connector>();
    //}

    //public List<City> Cities { get; private set; }
    //public List<Connector> Connectors { get; private set; }

}


