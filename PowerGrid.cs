using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.IO;
using System;
using UnityEngine;

public class PowerGrid : MonoBehaviour
{
    private static string kTAG = "MyGameTag";
    private Logger myLogger;

    public int playerAmount = 3;
    public int playerOrder = 0;
    public int turn = 0;
    public int phase = 1;
    public int step = 1;

    public Map map;
    public City city;
    public City myCity;
    public Player player;
    public scoringTrack Score;

 

    // Start is called before the first frame update
    void Start()
    {

        myLogger = new Logger(new MyLogHandler());

        myLogger.Log(kTAG, "MyGameClass Start.");

        map = new Map("Green", "Assets/data/germany-sectors.dat", "Assets/data/germany-connections.dat");

        List<City> allCities = map.getCityList();
        myCity = allCities[0];

        SetUpPhase setUp = gameObject.GetComponent<SetUpPhase>();

        setUp.SetDeckandMarket();
        setUp.SetFirstTurnPlayerOrder();
        setUp.SetPlayerElektro();
        setUp.SetMapPlayerArea();
    }

    // Update is called once per frame
    void Update()
    {
        Steps steps = gameObject.GetComponent<Steps>();

        PhaseLoop();

        if (step == 1)
            steps.StepOne();

        else if (step == 2)
           steps.StepTwo();

        else if (step == 3)
            steps.StepThree();

        else
            Endgame();


        //Check if the game has been won:
        int playerScore = player.playerBuildings.Count();

        //End game if needed
        if (playerScore > 17)
            EndGame();


        //if (Score >= 17)
        //{
        //    Endgame();
        //}

        //if (Score >= 17)
        //{
        //    Endgame();
        //}
    }


    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
            return;

        //Set white colour
        Gizmos.color = Color.white;

        //Otherwise run through all cities in map
        foreach (var city in map.cities)
        {
            //Draw a sphere
            Gizmos.DrawSphere(city.position, 1f);

            //Draw a label here
            UnityEditor.Handles.Label(city.position + Vector3.up * 2, $"{city.name}\n({city.sector.name})");

            //Draw a line to it
            Gizmos.DrawLine(city.position + Vector3.up * 1.25f, city.position + Vector3.up * 1.75f);
        }


        //set to a colour
        Gizmos.color = Color.green;

        foreach (var connection in map.connections)
        {
            //Get a and b positions
            var aPos = connection.a.position;
            var bPos = connection.b.position;

            //Draw a line from A to B
            Gizmos.DrawLine(aPos, bPos); 

            //Draw a label halfway between the two, showing the price. This position is:
            //(a + b) / 2 + (0, 2.5, 0)
            var meanPos = (aPos + bPos) / 2f + Vector3.up * 2.5f;

            //Draw label here
            UnityEditor.Handles.Label(meanPos, $"({connection.price})");
        }
    }


    public void TraversalTest()
    {
        List<City> neighbour = new List<City>();
        print(myCity.position);


        for (int i = 0; i < myCity.connections.Count; i++)
        {
            if (myCity.connections[i].outCity != myCity)
            {
                neighbour.Add(myCity.connections[i].outCity);
            }

            else
            {
                neighbour.Add(myCity.connections[i].outCity);
            }
        }

        myCity = neighbour[UnityEngine.Random.Range(0, neighbour.Count)];
        print(myCity.position);
    }


    public void PhaseLoop()
    {

        Phases phases = gameObject.GetComponent<Phases>();

        phases.PhaseOne();
        phases.PhaseTwo();
        phases.PhaseThree();
        phases.PhaseFour();
        phases.PhaseFive();

        //Check if a player has won
        bool won = checkPlayerHasWon();

        //Someone's won
        if (won)
            EndGame();

        turn++;
    }

    public void Endgame()
    {
      
    }

    public bool checkPlayerHasWon()
    {
        foreach (var player in players)
        {
            //Does this player have a score above 17? If they did, they won
            if (player.playerBuildings.Count() > 17)
                return true;
        }

        //No player had a score over 10: nobody won
        return false;
    }

}

public class Elektro
{
    
}

public class scoringTrack
{
//    public List<City> playerBuildings;

//    void Start()
//    {
//        int playerScore = playerBuildings.Count();
//        player.playerBuildings.Count() > 17;
//        if (playerScore > 17)
//                EndGame();
//    }

//    private void HandleScore()
//    {
//        //scoreText.text = "Score: " + currentScore;
//    }

}

public class MyLogHandler : ILogHandler
{
    public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
    {
        Debug.unityLogger.logHandler.LogFormat(logType, context, format, args);
    }

    public void LogException(Exception exception, UnityEngine.Object context)
    {
        Debug.unityLogger.LogException(exception, context);
    }
}