using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Dynamic;

public class Map
{
    // [HideInInspector]
   //public Map map;




    /// <summary>
    /// The cities in this map
    /// </summary>
    /// <typeparam name="City"></typeparam>
    /// <returns></returns>
    public List<City> cities = new List<City>();

    public List<City> getCityList()
    {
        return cities;
    }

    /// <summary>
    /// A dictionary of string -> city. This is to remove the need for constantly looking up cities with a 
    /// particular name. Instead, we can just reference through this map.
    /// </summary>
    /// <typeparam name="string"></typeparam>
    /// <typeparam name="City"></typeparam>
    /// <returns></returns>
    public Dictionary<string, City> cityHashMap = new Dictionary<string, City>();

    /// <summary>
    /// The sectors in this map
    /// </summary>
    /// <typeparam name="Sector"></typeparam>
    /// <returns></returns>
    public List<Sector> sectors = new List<Sector>();

    /// <summary>
    /// The edges of the graph -- routes between cities
    /// </summary>
    /// <typeparam name="Connector"></typeparam>
    /// <returns></returns>
    public List<Connector> connections = new List<Connector>();

    /// <summary>
    /// The map name
    /// </summary>
    public string name;

    /// <summary>
    /// Sets up a new map.
    /// </summary>
    /// <param name="name"></param>
    public Map(string name, string sectorsFile, string connectionsFile)
    {
        //Set the name
        this.name = name;

        //Load in sectors data.
        this.sectors = this.ParseSectorsFromFile(sectorsFile);

        //Load in connections data.
        this.connections = this.ParseConnectorsFromFile(connectionsFile);
    }

    /// <summary>
    /// Parses connections from a file
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    private List<Connector> ParseConnectorsFromFile(string filename)
    {
        //Set connections initially
        connections = new List<Connector>();

        //Get the contents of the file
        var lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            //Comment or empty, skip
            if (line.Length == 0 || line[0] == '#' || line[0] == ' ' || string.IsNullOrWhiteSpace(line))
                continue;

            //splits the line into space-delimited chunks
            var chunks = line.Split(' ');

            //NO ERROR CHECKING IS DONE BELOW FOR INVALID LINE FORMAT

            //From, to, and the cost
            var from = chunks[0];
            var to = chunks[2].Replace(":", "");
            var price = int.Parse(chunks[3]);

            //NO ERROR CHECKING IS DONE HERE TO CHECK IF THE CITY ACTUALLY EXISTS
            //USE .KeyExists TO CHECK

            //Find the cities in the map
            var cityA = cityHashMap[from];
            var cityB = cityHashMap[to];

            //Make a connection
            var connection = new Connector(ref cityA, ref cityB, price);

            //Add connection
            connections.Add(connection);
        }

        //Return the connections
        return connections;
    }

    /// <summary>
    /// Parses the sectors from a file
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    private List<Sector> ParseSectorsFromFile(string filename)
    {
        //Create a new list of sectors
        sectors = new List<Sector>();

        //Get the contents of the file
        var lines = File.ReadAllLines(filename);

        //The current sector
        Sector currentSector = null;

        foreach(var line in lines)
        {
            //Comment or empty, skip
            if(line.Length == 0 || line[0] == '#'|| line[0] == ' ' || string.IsNullOrWhiteSpace(line))
                continue;

            //Line begins with a square bracket? this is a new sector
            if(line.Trim()[0] == '[')
            {
                //Push the last one if this one is not null
                if(currentSector != null)
                    sectors.Add(currentSector);

                //Find the sector name
                var sectorName = line.Substring(1, line.Length - 2);

                //Make a new sector
                currentSector = new Sector(sectorName);
            }
            else
            {
                //Not a comment, not an empty line, so its a city
                if(currentSector == null)
                    throw new UnityException("Found city name before I found a sector name. Unacceptable file format.");

                //Split the line into chunks
                var chunks = line.Split(' ');

                //Cool, so now we just need to get the city name
                var cityName = chunks[0].Trim().Replace(":", "");

                //The x is the second chunk, etc
                var x = float.Parse(chunks[1].Trim().Replace(",", ""));
                var y = float.Parse(chunks[2].Trim().Replace(",", ""));

                //Make a new city, add it to the cities list & hashmap
                var city = new City(cityName, currentSector, new Vector2(x, y));
                cities.Add(city);
                cityHashMap.Add(cityName, city);

                //Add this city to this sector
                currentSector.cities.Add(city);                
            }
        }

        //We've reached the end of the file
        if(currentSector != null)
            sectors.Add(currentSector);

        //Return them
        return sectors;
    }
}
