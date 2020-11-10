using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.IO;
using System;
using UnityEngine;
using System.Diagnostics;


public class MyLogHandler : ILogHandler
{
    private FileStream m_FileStream;
    private StreamWriter m_StreamWriter;
    private ILogHandler m_DefaultLogHandler = UnityEngine.Debug.unityLogger.logHandler;

    //Static instance for access from other files
    public static MyLogHandler instance;

    public MyLogHandler()
    {
        //Setup instance
        instance = this;

        //use like this (from other files):
        //MyLogHandler.instance.Log("hello there");

        string filePath = Application.persistentDataPath + "/MyLogs.txt";

        m_FileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        m_StreamWriter = new StreamWriter(m_FileStream);

        // Replace the default debug log handler
        UnityEngine.Debug.unityLogger.logHandler = this;
    }

    public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
    {
        m_StreamWriter.WriteLine(String.Format(format, args));
        m_StreamWriter.Flush();
        m_DefaultLogHandler.LogFormat(logType, context, format, args);
    }

    public void LogException(Exception exception, UnityEngine.Object context)
    {
        m_DefaultLogHandler.LogException(exception, context);
    }
}

public class PowerGrid : MonoBehaviour
{

    public int turn = 0;
    public int phase = 1;
    public int step = 1;

    public Map map;
    public City city;
    public City myCity;
    public List<Player> players = new List<Player>();
    public SetUpPhase setUp;
    public scoringTrack Score;

    public Phases phases = new Phases();
    public Steps steps = new Steps();

    //Player owned Resources
    public List<Coal> playerCoal;
    public List<Oil> playerOil;
    public List<Garbage> playerGarbage;
    public List<Nuclear> playerNuclear;

    //Player Elektro 
    public int playerElektro = 50;

    //Player owned power plant cards
    public List<Card> playerPowerPlants;

    //Player owned cities
    public List<City> playerBuildings;

    private static ILogger logger = UnityEngine.Debug.unityLogger;
    private Logger myLogger;

    // Start is called before the first frame update
    void Start()
    {
        myLogger = new Logger(new MyLogHandler());

        map = new Map("Green", "Assets/data/germany-sectors.dat", "Assets/data/germany-connections.dat");
        map.FindAdjacentSectorData();

        //foreach (var sector in map.sectors)
        //{
        //    UnityEngine.Debug.Log($"Sector {sector.name} is adjacent to:");

        //    foreach (var adj in sector.adjacentSectors)
        //        UnityEngine.Debug.Log("\t" + adj.name);
        //}

        List<City> allCities = map.getCityList();
        myCity = allCities[0];

        setUp = new SetUpPhase();
        setUp.SetDeckandMarket();
        setUp.SetResourceMarket();

        //Adding the players to the player list
        players.Add(new Player());
        players.Add(new Player());
        players.Add(new Player());
        //myLogger.Log(players, "Added new players");
        //UnityEngine.Debug.Log(setUp);
    }

    // Update is called once per frame
    void Update()
    {
        

        PhaseLoop();

        if (step == 1)
            steps.StepOne();

        else if (step == 2)
           steps.StepTwo();

        else if (step == 3)
            steps.StepThree();
        //myLogger.Log(steps, "it is now step {0}");
        else
            EndGame();
        //myLogger.Log(EndGame, "");

        foreach (var player in players)
        {
            //Check if the game has been won:
            int playerScore = player.playerBuildings.Count;

            //Step Two trigger
            if (playerScore > 7)
                step = 2;
            //myLogger.Log(EndGame, "");

            //End game if needed
            if (playerScore > 17)
                EndGame();
            //myLogger.Log(EndGame, "");
        }


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
            UnityEditor.Handles.Label(city.position + Vector3.up * 3, $"{city.name}\n({city.sector.name})");

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


    //public void TraversalTest()
    //{
    //    List<City> neighbour = new List<City>();
    //    print(myCity.position);


    //    for (int i = 0; i < myCity.connections.Count; i++)
    //    {
    //        if (myCity.connections[i].outCity != myCity)
    //        {
    //            neighbour.Add(myCity.connections[i].outCity);
    //        }

    //        else
    //        {
    //            neighbour.Add(myCity.connections[i].outCity);
    //        }
    //    }

    //    myCity = neighbour[UnityEngine.Random.Range(0, neighbour.Count)];
    //    print(myCity.position);
    //}


    public void PhaseLoop()
    {

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

    public void EndGame()
    {
      
    }

    public bool checkPlayerHasWon()
    {
        //foreach (var players in players)
        //{
        //    //Does this player have a score above 17? If they did, they won
        //    if (players.playerBuildings.Count() > 17)
        //        return true;
        //}

        //No player had a score over 10: nobody won
        return false;
    }

}

public class scoringTrack
{
//    public List<City> playerBuildings;

//    void Start()
//    {
//        int playerScore = playerBuildings.Count();
//        players.playerBuildings.Count() > 17;
//        if (playerScore > 17)
//                EndGame();
//    }

//    private void HandleScore()
//    {
//        //scoreText.text = "Score: " + currentScore;
//    }

}
