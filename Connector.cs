using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector 
{
    string name;

    public Connector(string name)
    {
        this.name = name;
    }

    public notInUseConnector (string name)
    {
        this.name = name;
    }
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