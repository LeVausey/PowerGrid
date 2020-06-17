using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using System.Linq;
using System.Diagnostics;

public class MapTest : MonoBehaviour
{
   public Map map;
   public City city;
    
   public void Start()
    {
        //Map.LoadInMap();

        //Make a new map
        map = new Map("green", "Assets/data/uk-sectors.dat", "Assets/data/uk-connections.dat");
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
        //var cities = new List<City>();
        //cities.Closure(city => city.ChildNodes).ToList();
    }
}
