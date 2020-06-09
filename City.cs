﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour //nodes
{
    /// <summary>
    /// A city has a name
    /// </summary>
    public string CityName { get; set; }

    public string SectorNum { get; set; }
    public Sector sector;

    //public void SetCityName 
    //{
    //    this.name = 
    //}

    public City (GameObject prefab, int x, int y)
    {
        Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity);
    }

    /// <summary>
    /// A city can be connected to other ones
    ///</summary>
    public List<string> connectedCities;

    List<Sector> sectors;

    List<BuildingSlot> buildingSlots;

    public List<Connector> ConnectorsIn;
    public List<Connector> ConnectorsOut;

    ///// <summary>
    ///// Connects this city with another city
    ///// </summary>
    ///// <param name="city"></param>
    //public void ConnectTo(City city)
    //{
    //    this.connectedCities.Add(city);
    //    city.connectedCities.Add(this);
    //}
}

public class Sector
{
    /// <summary>
    /// A sector has a list of "nodes" which are the cities within it
    /// </summary>
    List<City> cities;

    /// <summary>
    /// Adds a city to the list of cities for this sector
    /// </summary>
    /// <param name="city"></param>
    public void AddCity(City city)
    {
        cities.Add(city);
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
    /// Sets it to purchased
    /// </summary>
    public void SetPurchased()
    {
        this.purchased = true;
    }

    //public bool SetBuildingSlot(int buildingSlotIndex, int amountOfCurrentMoney)
    //{
    //    //Get the building slot at this index
    //    var buildingSlots = buildingSlots[buildingSlotIndex];

    //    //Do they have enough money to buy this slot? If not, then
    //    //return false
    //    if (amountOfCurrentMoney < buildingSlot)
    //        return false;

    //    //Otherwise, at this point, they do.. so buy it:
    //    buildingSlot.SetPurchased();

    //    //Decrement their money here
    //    //..
    //}
}