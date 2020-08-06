using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public SetUpPhase setUp;

    public List<Player> players = new List<Player>();
    public List<Player> bidders;
    public List<Player> nonBidders;
    public int playerElektro;

    // Start is called before the first frame update
    void Start()
    {
        setUp = new SetUpPhase();
        setUp.SetDeckandMarket();

        players.Add(new Player());
        players.Add(new Player());
    }

    //private phaseTwoAuction(List<Player> players)

    // Update is called once per frame
    void Update()
    {

        ////playerOrder
        //foreach (var player in players)
        //{
        //    ////Number of bidders initially
        //    int toBid = UnityEngine.Random.Range(0, 1);

        //    if (toBid == 0)
        //    {
        //        //dont bid
        //        bidButtonClicked = false;
        //    }

        //    if (toBid == 1)
        //    {
        //        bidButtonClicked = true;
        //    }

        //    if (bidButtonClicked == true)
        //    {
        //        bidders.Add(player);
        //    }


        //    //setting the range of the Elektro
        //    foreach (int value in Enumerable.Range(0, (playerElektro)))
        //    {
        //        //Get the money of this player
        //        var money = playerElektro[i];

        //        //the bidding
        //        while (toBid == 1 && playerElektro < current_bid + price_increment)
        //        {
        //            //player bids w.e you want to do here probs players_money - current_bid + increment
        //            toBid = UnityEngine.Random.Range(0, 1);
        //            if (bidders.count == 1)
        //            {
        //                //bidders.element(player) buys card

        //                player.BuyCard();
        //            }

                    
        //        }
        //    }
        //}
    }

    public class Auction<T>
    {
        public T Selection { get; }
        public Player HighBidder { get; }
        public int HighBid { get; }
        public List<Player> Participants { get; }

        public Auction(T selection, Player highBidder, int currentBid, List<Player> participants)
        {
            Selection = selection;
            HighBidder = highBidder;
            HighBid = currentBid;
            Participants = participants;
        }

        public Player GetPlayerAfter(Player player) => Participants.GetPlayerAfter(player);
        public Player GetNextPlayer() => GetPlayerAfter(HighBidder);
        public bool IsComplete => Participants.Count == 1;

        public Auction<T> MakeBid(T selection, Player player, int bid) => new Auction<T>(selection, player, bid, Participants);
        public Auction<T> Pass(Player player) => new Auction<T>(Selection, HighBidder, HighBid, Participants.Remove(player));
    }

    private PrivateAuctionRound(List<Player> players, Player activePlayer, Player lastToAct, int elektro)
            : base(players, activePlayer, lastToAct)
    {
        CurrentAuction = auction;
        playerElektro = elektro;
    }

    //public static PrivateAuctionRound StartOfRound(List<Player> players) =>
    //       new PrivateAuctionRound(players, null, players.First(), players.Last());


    //private PrivateAuctionRound StartAuction(Player biddingPlayer, PrivateCompany selection, int bid)
    //{
    //    var auction = new Auction<PrivateCompany>(selection, biddingPlayer, bid, Players);
    //    return Update(auction: auction, activePlayer: Players.GetPlayerAfter(biddingPlayer), lastToAct: biddingPlayer);
    //}

    //public static GameState MakeBid(PrivateAuctionRound round, PlayerState biddingPlayerState, int bid)
    //{
    //    if (round.CurrentAuction == null)
    //    {
    //        // No auction is in progress so start a new auction for the selected private 
    //        round = round.StartAuction(biddingPlayerState.Player, selection, bid);
    //    }
    //    else
    //    {
    //        // Apply the new bid to the current auction
    //        var newAuction = round.CurrentAuction.MakeBid(biddingPlayerState.Player, bid);
    //        round = round.Update(auction: newAuction, activePlayer: newAuction.GetNextPlayer());
    //    }

    //    if (bid == selection.Value)
    //    {
    //        // Maximum bid was made, auction terminates                                
    //        return CompleteAuction(gameState, round);
    //    }

    //    return gameState.WithRound(round);
    //}

    //public static GameState Pass(GameState gameState, PrivateAuctionRound round, Player passingPlayer)
    //{
    //    if (round.CurrentAuction != null)
    //    {
    //        var newAuction = round.CurrentAuction.Pass(passingPlayer);
    //        if (newAuction.IsComplete)
    //        {
    //            return CompleteAuction(gameState, round);
    //        }

    //        // auction continues                    
    //        round = round.Update(auction: newAuction, activePlayer: newAuction.GetNextPlayer());
    //        return gameState.WithRound(round);
    //    }
    //    else if (round.ActivePlayer == round.LastToAct)
    //    {
    //        // Exit the auction round early as everyone passed
    //        var priorityDeal = round.Players.GetPlayerAfter(round.LastToAct);
    //        var newRound = StockRound.StartOfRound(round.Players, 1, priorityDeal);
    //        return new GameState(gameState.Game, newRound, priorityDeal, gameState.PlayerStates, gameState.CompanyStates);
    //    }
    //    else
    //    {
    //        // player elects not to put anything up for auction
    //        var newRound = round.Update(activePlayer: gameState.Game.Players.GetPlayerAfter(passingPlayer));
    //        return gameState.WithRound(newRound);
    //    }
    //}

    //private static GameState CompleteAuction(GameState gameState, PrivateAuctionRound round)
    //{
    //    var currentAuction = round.CurrentAuction;
    //    var stateForWinningPlayer = gameState.GetPlayerState(currentAuction.HighBidder);

    //    var newPlayerStates = gameState.PlayerStates.Replace(stateForWinningPlayer,
    //        new PlayerState(stateForWinningPlayer.Player, stateForWinningPlayer.Money - currentAuction.HighBid, winningPlayerPrivates));

    //    var seedFunding = currentAuction.Selection.Value - currentAuction.HighBid;

    //    Round newRound;
    //    if (remainingPrivates.IsEmpty)
    //    {
    //        newRound = StockRound.StartOfRound(round.Players, 1, nextPlayer);
    //        return new GameState(gameState.Game, newRound, nextPlayer, newPlayerStates, gameState.CompanyStates);
    //    }
    //    else
    //    {
    //        newRound = new PrivateAuctionRound(round.Players, remainingPrivates, null, nextPlayer, round.LastToAct, round.SeedMoney - seedFunding);
    //    }


    //}

    //temp fix
    //public override IEnumerable<IChoice> GetChoices(GameState gameState)
    //{
    //    var choices = new List<IChoice>();
    //    choices.Add(new PassChoice());

    //    var playerState = gameState.GetPlayerState(ActivePlayer);

    //    if (CurrentAuction != null)
    //    {
    //        choices.Add(GetLegalBid(playerState, CurrentAuction.Selection));
    //    }
    //    else
    //    {
    //        foreach (var company in Privates)
    //            choices.Add(GetLegalBid(playerState, company));
    //    }

    //    return choices.Where(c => c != null);
    //}
}

