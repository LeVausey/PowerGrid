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
            string[] entries = line.Split(',');

            City newCity = new City();

            Connector newConnector = new Connector();

            newCity.CityName = entries[0];
            newCity.SectorNum = entries[1];
            newConnector.Connection = entries[2];

            cities.Add(newCity);
            connectors.Add(newConnector);
        }

        foreach (var city in cities)
            Debug.Log($"{city.CityName} {city.SectorNum}");

        foreach (var connector in connectors)
            Debug.Log($"{connector.Connection}");

        Console.ReadLine();
    }

    public Map(int numCities, int numConnectors)
    {
        cities = new int[numCities + 1];
        cities[cities.Length - 1] = numConnectors;
        connector = new int[numConnectors];
    }
	int connectorTotal;

	public MapBuider()
	{
		cities = new List<City>();
	}


	//	Start a new node.
	public void NewCity()
	{
		cities.Add(new List<City>());
	}

	public void AddConnector(params int[] targetCities)
	{
		List<City> currCities = (List<City>)cities[cities.Count - 1];

		for (int i = 0; i < targetCities.Length; i++)
		{
			currCities.Add(targetCities[i]);
		}

		connectorTotal += targetCities.Length;
	}


	//	Build a Map from the temporary graph contained by the builder.
	public Map Build()
	{
		Map result = new Map(cities.Count, connectorTotal);
		int currConnector = 0;

		for (int i = 0; i < cities.Count; i++)
		{
			result.cities[i] = currConnector;
			List<City> currConnector = (ArrayList)nodes[i];
			currCities.CopyTo(result.connector, currConnector);
			currConnector += currCities.Count;
		}

		return result;
	}

}


