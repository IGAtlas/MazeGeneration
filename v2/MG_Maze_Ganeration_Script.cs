using UnityEngine;

public class MG_Maze_Ganeration_Script : MonoBehaviour
{
    //Hold instances of maze paths
    //Generat maze paths dependent on rules
    //Rules:
    //Generate anything to start with
    //Then agin
    //If generated pathway is right turn then all extra generated pathways must have an added value to there rotation

    public GameObject Hallway;
    public GameObject TSection;
    public GameObject RightTurn;
    public GameObject LeftTurn;
    public GameObject EndCap;
    public int RandomNumber;
    //Placement
    public MG_Maze_Hallway_Script HallwayScript;
    public MG_Maze_RightTurn_Script RightTurnScript;
    public MG_Maze_LeftTurn_Script LeftTurnScript;
    public MG_Maze_TSection_Script TSectionScript;
    public MG_Maze_Count_Script CountScript;
    //count
    public int count = 0;

    void Start()
    {
        MazeGeneration();
    }

    void Update()
    {

    }

    void MazeGeneration()
    {
        //Now will spawn an object to start
        //Run its script
        //Each script will then do the same up to the max amount
        if (CountScript.Count <= CountScript.MaxCount)
        {
            CountScript.Count += 1;
            RandomNumber = Random.Range(1, 5);
            if (RandomNumber == 1)//Hallway
            {
                Instantiate(Hallway);
                HallwayScript.RunHallway();
            }
            if (RandomNumber == 2)//TSection
            {
                Instantiate(TSection);
                TSectionScript.RunTSection();
            }
            if (RandomNumber == 3)//RightTurn
            {
                Instantiate(RightTurn);
                RightTurnScript.RunRightTurn();
            }
            if (RandomNumber == 4)//LeftTurn
            {
                Instantiate(LeftTurn);
                LeftTurnScript.RunLeftTurn();
            }
        }
    }
}
