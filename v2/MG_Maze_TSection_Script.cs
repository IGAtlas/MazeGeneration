using UnityEngine;

public class MG_Maze_TSection_Script : MonoBehaviour
{
    //Scripts
    public MG_Maze_Hallway_Script HallwayScript;
    public MG_Maze_RightTurn_Script RightTurnScript;
    public MG_Maze_LeftTurn_Script LeftTurnScript;
    public MG_Maze_Count_Script CountScript;
    //Objects
    public GameObject Hallway;
    public GameObject TSection;
    public GameObject RightTurn;
    public GameObject LeftTurn;
    public GameObject EndCap;
    //RandomNumber
    public int RandomNumber;
    //Spawn location and rotation
    public Transform Spawn;
    //count
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunTSection()
    {
        if(CountScript.Count <= CountScript.MaxCount)
        {
            CountScript.Count += 1;
            RandomNumber = Random.Range(1, 5);
            if (RandomNumber == 1)//Hallway
            {
                Instantiate(Hallway, Spawn.position, Spawn.rotation);
                HallwayScript.RunHallway();
            }
            if (RandomNumber == 2)//TSection
            {
                Instantiate(TSection, Spawn.position, Spawn.rotation);
                RunTSection();
            }
            if (RandomNumber == 3)//RightTurn
            {
                Instantiate(RightTurn, Spawn.position, Spawn.rotation);
                RightTurnScript.RunRightTurn();
            }
            if (RandomNumber == 4)//LeftTurn
            {
                Instantiate(LeftTurn, Spawn.position, Spawn.rotation);
                LeftTurnScript.RunLeftTurn();
            }
        }

    }
}
