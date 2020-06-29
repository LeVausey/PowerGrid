using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using System.Linq;

public class MapTest : MonoBehaviour
{
    public Map map;
    public City city;
    public City myCity;

   

    
    public void Start()
    {
        //Map.LoadInMap();

        //Make a new map
        map = new Map("Green", "Assets/data/germany-sectors.dat", "Assets/data/germany-connections.dat");

        List<City> allCities = map.getCityList();
        myCity = allCities[0];
    }

    public void OnDrawGizmos()
    {
        if(!Application.isPlaying)
            return;

        //Set white colour
        Gizmos.color = Color.white;

        //Otherwise run through all cities in map
        foreach(var city in map.cities)
        {
            //Draw a sphere
            Gizmos.DrawSphere(city.position, 1f);

            //Draw a label here
            UnityEditor.Handles.Label(city.position + Vector3.up * 2, $"{city.name}\n({city.sector.name})");

            //Draw a line to it
            Gizmos.DrawLine(city.position + Vector3.up * 1.25f, city.position + Vector3.up * 1.75f);
        }


        //set to a colour
        Gizmos.color = Color.green;

        foreach(var connection in map.connections)
        {
            //Get a and b positions
            var aPos = connection.a.position;
            var bPos = connection.b.position;

            //Draw a line from A to B
            Gizmos.DrawLine(aPos, bPos);

            //Draw a label halfway between the two, showing the price. This position is:
            //(a + b) / 2 + (0, 2.5, 0)
            var meanPos = (aPos + bPos) / 2f + Vector3.up * 2.5f;

            //Draw label here
            UnityEditor.Handles.Label(meanPos, $"({connection.price})");
        }
    }

  
    public void TraversalTest()
    {
        List<City> neighbour = new List<City>();
        print(myCity.position);
       

        for (int i = 0; i < myCity.connections.Count; i++)
        {        
            if (myCity.connections[i].outCity != myCity)
            {
                neighbour.Add(myCity.connections[i].outCity);
            }

            else
            {
                neighbour.Add(myCity.connections[i].outCity);
            }
        }

        myCity = neighbour[UnityEngine.Random.Range(0,neighbour.Count)];
        print(myCity.position);
    }
}
