using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class City
{
    /// <summary>
    /// The name of this city.
    /// </summary>
    public string name;

    /// <summary>
    /// The sector (as far as im aware, a city can only have one?)
    /// </summary>
    public Sector sector;

    /// <summary>
    /// The list of cities this city is connected to
    /// </summary>
    public List<OutConnection> connections = new List<OutConnection>();

    /// <summary>
    /// The building slots for this city.
    /// </summary>
    public List<BuildingSlot> buildingSlots = new List<BuildingSlot>();

    /// <summary>
    /// Each city has a position
    /// </summary>
    public Vector3 position;

    /// <summary>
    /// Creates a new city with a given name and sector.
    /// </summary>
    /// <param name="name">The name of the city.</param>
    /// <param name="sector">The sector of the city.</param>
    public City(string name, Sector sector)
    {
        //Set variables
        this.name = name;
        this.sector = sector;

        //Setup three default building slots for each city
        buildingSlots.Add(new BuildingSlot(10));
        buildingSlots.Add(new BuildingSlot(15));
        buildingSlots.Add(new BuildingSlot(20));
    }

    /// <summary>
    /// Creates a new city with a given name and sector.
    /// </summary>
    /// <param name="name">The name of the city.</param>
    /// <param name="sector">The sector of the city.</param>
    public City(string name, Sector sector, Vector2 position)
    {
        //Set variables
        this.name = name;
        this.sector = sector;

        //Position
        this.position = new Vector3(position.x, 0, position.y);

        //Setup three default building slots for each city
        buildingSlots.Add(new BuildingSlot(10));
        buildingSlots.Add(new BuildingSlot(15));
        buildingSlots.Add(new BuildingSlot(20));
    }
}



public class Sector
{
    /// <summary>
    /// A sector just contains a list of cities
    /// </summary>
    public List<City> cities = new List<City>();

    /// <summary>
    /// The sector name -- not sure if sectors have names
    /// </summary>
    public string name;

    /// <summary>
    /// Creates a new sector with a given name
    /// </summary>
    /// <param name="name">The name of the sector</param>
    public Sector(string name)
    {
        this.name = name;
    }
}



public class BuildingSlot
{
    /// <summary>
    /// Is this slot purchased?
    /// </summary>
    public bool purchased;

    /// <summary>
    /// The price of this slot
    /// </summary>
    public int price;

    /// <summary>
    /// Creates a building slot
    /// </summary>
    /// <param name="price"></param>
    public BuildingSlot(int price)
    {
        this.purchased = false;
        this.price = price;
    }

    /// <summary>
    /// Sets it to (not) purchased
    /// </summary>
    public void SetPurchased(bool value)
    {
        this.purchased = value;
    }
}