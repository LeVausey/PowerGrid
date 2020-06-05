using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector //edge
{
    public string Connection { get; set; }

    public City From;
    public City To;

    City target;
}

public class ConnectorCost
{
    /// <summary>
    /// The price of the connector
    /// </summary>
    public int price;

    /// <summary>
    /// Creates a connector
    /// </summary>
    /// <param name="price"></param>
    public ConnectorCost(int price)
    {
        this.price = price;
    }
}