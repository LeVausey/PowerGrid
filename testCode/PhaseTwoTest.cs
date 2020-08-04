using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseTwoTest : MonoBehaviour
{

    public int phaseNum;
    public bool phase;
    public int playerOrder;
    public int turn = 0;
    public int i;
    public bool bidButtonClicked;
    public bool bid;

    public int current_bid;
    public int price_increment;
    public Player player;

    public List<Player> players = new List<Player>();
    public List<Player> bidders;
    public List<Player> nonBidders;
    public int playerElektro;

    // Start is called before the first frame update
    void Start()
    {
        setUp = new SetUpPhase();
        setUp.SetDeckandMarket();
        setUp.SetResourceMarket();

        players.Add(new Player());
        players.Add(new Player());
    }

    // Update is called once per frame
    void Update()
    {
        //playerOrder
        foreach (var player in players)
        {

            //////Number of bidders initially
            //int toBid = UnityEngine.Random.Range(0, 1);

            //if (toBid == 0)
            //{
            //    //dont bid
            //    bidButtonClicked = false;
            //}

            //if (toBid == 1)
            //{
            //    bidButtonClicked = true;
            //}

            //if (bidButtonClicked == true)
            //{
            //    bidders.Add(player);
            //}


            ////setting the range of the Elektro
            //foreach(int value in Enumerable.Range(0, (playerElektro)))
            //{
            //    //Get the money of this player
            //    var money = playerElektro[i];

            //    //the bidding
            //    while (toBid == 1 && playerElektro < current_bid + price_increment)
            //    {
            //        //player bids w.e you want to do here probs players_money - current_bid + increment
            //        toBid = UnityEngine.Random.Range(0, 1);
            //        if (bidders.count == 1)
            //        {
            //            //bidders.element(player) buys card

            //            player.BuyCard();
            //        }
            //    }
            //}

        }
    }
}
