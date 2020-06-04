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

        List<Connector> connectors = new List<Connector>();

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
    
    private IList<HashSet<int>> _connectors;

    public int City { get; private set; }

    public List<Connector> connectors { get; private set; }


    public Map(int numCities, IList<Tuple<int, int>> connectors)
    {
        City = numCities;
        _connectors = new List<HashSet<int>>(numCities);
        for (int i = 0; i < numCities; i++)
        {
            _connectors.Add(new HashSet<int>());
        }

        foreach (var connector in connectors)
        {
            _connectors[connector.Item1].Add(connector.Item2);
            _connectors[connector.Item2].Add(connector.Item1);
        }
    }

    public IEnumerable<int> Neighbours(int city)
    {
        return _connectors[city];
    }
}



