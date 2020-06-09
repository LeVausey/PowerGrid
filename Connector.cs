using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector : MonoBehaviour //edge
{
    public string Connection { get; set; }

    public City From;
    public City To;

    //public Transform target;

    //public Connector(GameObject prefab, int x, int y)
    //{
    //    Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity);
    //}

    //void OnDrawGizmos()
    //{
    //    // Draws a black line from this transform to the target
    //    Gizmos.color = Color.black;
    //    Gizmos.DrawLine(transform.position, target.position);
    //}
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