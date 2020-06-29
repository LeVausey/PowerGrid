using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MarketTest : MonoBehaviour
{
    public List<Card> drawedCards;
    public List<Card> currentMarket;
    public List<Card> futureMarket;

    // Start is called before the first frame update
    void Start()
    {
        //Sort the drawed cards
        drawedCards = drawedCards.OrderBy(x => x.getFaceValue()).ToList();

        //Sort the lower numbered cards into the current market
        drawedCards = currentMarket.OrderBy(x => x.getFaceValue()).ToList();

        //Sort the higher numbered cards into the future market
        drawedCards = futureMarket.OrderBy(x => x.getFaceValue()).ToList();

        Debug.Log("Drawed cards:");

        ////Print them out to test
        foreach (var card in drawedCards)
            Debug.Log(card);

    }

}
