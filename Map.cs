﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Map : MonoBehaviour
{
    public List<City> cities = new List<City>();
    public List<Connector> connectors = new List<Connector>();

    public GameObject myCity;

    public GameObject myConnector;


    //public Transform target;
    //public float explosionRadius = 5.0f;
    //public static int boardSize = 10;

    void Start()
    {
        string filePath = @"C:\Users\Jacob\Documents\Masters\PowerGrid\PowerGrid\Assets\Scripts\Test.txt";

        List<string> lines = File.ReadAllLines(filePath).ToList();
        int x = 1;

        foreach (var line in lines)
        {
            //The entries
            string[] entries = line.Split(',');

            //The number of cities in this line (entry count - 2)
            int connectedCityCount = entries.Length - 0;

            //Make a new city for this line
            City newCity = new City(myCity, x, 0);

            newCity.CityName = entries[0];
            newCity.SectorNum = entries[1];

            for (int i = 2; i < connectedCityCount; i++)
            {
                //We're running from 2 (skip 0, and 1, because they're city name + sector number)
                //because each entry here is a city which is connected to this one.

                ////Make a new connection
                ////newConnector.Connection = entries[i];

                ////Add the connection
                ////connectors.Add(newConnector);

                newCity.connectedCities.Add(entries [i]);
            }

            cities.Add(newCity);
            x++;
        }

        foreach (var city in cities)
            Debug.Log($"{city.CityName} {city.SectorNum}");

        foreach (var city in cities)
        {
            foreach (var connectedCity in city.connectedCities)
            {
                List<City> someCities = cities.Where(aCity => aCity.CityName == connectedCity).ToList();
                Connector newConnector = new Connector();
                newConnector.From = city;
                newConnector.To = someCities.First();
                city.ConnectorsOut.Add(newConnector);
                someCities.First().ConnectorsIn.Add(newConnector);

                connectors.Add(newConnector);
            }
        }
        
        foreach (var connector in connectors)
            Debug.Log($"{connector.Connection}");

        Console.ReadLine();
    }

   

    //void OnDrawGizmos()
    //{
    //    // Draws a black line from this transform to the target
    //    Gizmos.color = Color.black;
    //    Gizmos.DrawLine(transform.position, target.position);
    //    Gizmos.DrawWireSphere(transform.position, explosionRadius);
    //    Gizmos.DrawWireCube(transform.position, new Vector2(boardSize * 10, boardSize * 0));
    //}
}


