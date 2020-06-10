using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents an undirected edge in a graph
/// </summary>
[System.Serializable]
public class Connector
{
    /// <summary>
    /// Vertex A
    /// </summary>
    public City a;

    /// <summary>
    /// Vertex B
    /// </summary>
    public City b;

    /// <summary>
    /// The price of the connection
    /// </summary>
    public int price;

    /// <summary>
    /// Creates a new connection between a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public Connector(ref City a, ref City b, int price)
    {
        //Set a and b.
        this.a = a;
        this.b = b;

        //The price
        this.price = price;

        //Build outbound connections for a and b so they can see each other
        this.a.connections.Add(new OutConnection(this.b, this.price));
        this.b.connections.Add(new OutConnection(this.a, this.price));
    }
}

public class OutConnection
{
    /// <summary>
    /// An out city
    /// </summary>
    public City outCity;

    /// <summary>
    /// The inherited price
    /// </summary>
    public int price;

    /// <summary>
    /// Makes a new outbound connection (for local view for city)
    /// </summary>
    /// <param name="outCity"></param>
    /// <param name="price"></param>
    public OutConnection(City outCity, int price)
    {
        this.price = price;
        this.outCity = outCity;
    }
}