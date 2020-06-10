using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTest : MonoBehaviour
{
    // [HideInInspector]
    public Map map;

    private void Start()
    {
        //Make a new map
        map = new Map("lincolnshire", "Assets/data/uk-sectors.dat", "Assets/data/uk-connections.dat");


        // LOOPING THROUGH ALL SECTORS + CITIES
        // ====================================

        // //Lets loop through all the sectors
        // foreach(var sector in map.sectors)
        // {
        //     //Lets loop through all the cities in this sector
        //     foreach(var city in sector.cities)
        //         Debug.Log($"Sector {sector.name} has city {city.name}");
        // }



        //LOOPING THROUGH ALL CONNECTIONS (globally)
        //====================================

        //Lets loop through all the connections
        // foreach(var connection in map.connections)
        //     Debug.Log($"Connection between {connection.a.name} & {connection.b.name} costs {connection.price}");



        //LOOPING THROUGH ALL CONNECTIONS OF ONE CITY (locally)
        //====================================

        // //Lets check all the connections from lincoln
        // foreach(var connection in map.cityHashMap["Lincoln"].connections)
        //     Debug.Log($">> Lincoln is connected to {connection.outCity.name}, cost is {connection.price}");
    }




    public void OnDrawGizmos()
    {
        //In editor? gtfo
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




        //Now the trickier bit, drawing connections. First set to a colour
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
}
