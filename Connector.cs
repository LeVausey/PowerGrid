using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector
{
    public string Connection { get; set; }

    public City From;
    public City To;

    City target;
    double weight;
}

public class ConnectorCost
{
    /// <summary>
    /// The price of this slot
    /// </summary>
    public int price;

    /// <summary>
    /// Creates a building slot
    /// </summary>
    /// <param name="price"></param>
    public ConnectorCost(int price)
    {
        this.price = price;
    }
}