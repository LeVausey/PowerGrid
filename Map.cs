using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Map : MonoBehaviour
{
	public List<City> cities = new List<City>();

	public List<Connector> connectors = new List<Connector>();

	void Start()
    {
        string filePath = @"C:\Users\Jacob\Documents\Masters\PowerGrid\PowerGrid\Assets\Scripts\Test.txt";

        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
			//The entries
			string[] entries = line.Split(',');

			//The number of cities in this line (entry count - 2)
			int connectedCityCount = entries.Length - 2;

			//Make a new city for this line
			City newCity = new City();

            newCity.CityName = entries[0];
            newCity.SectorNum = entries[1];

			for (int i = 2; i < connectedCityCount; i++)
			{
				//We're running from 2 (skip 0, and 1, because they're city name + sector number)
				//because each entry here is a city which is connected to this one.

				//Make a new connection
				Connector newConnector = new Connector();
				newConnector.Connection = entries[i];

				//Add the connection
				connectors.Add(newConnector);
			}


			cities.Add(newCity);
        }

        foreach (var city in cities)
            Debug.Log($"{city.CityName} {city.SectorNum}");

        foreach (var connector in connectors)
            Debug.Log($"{connector.Connection}");

        Console.ReadLine();
    }
}


