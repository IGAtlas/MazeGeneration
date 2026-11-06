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
    public int RotationValue;
    //Placement
    public int LoactionInSpaceX = 0;
    public int LoactionInSpaceY = 0;
    public int LoactionInSpaceZ = 0;
    //Rotation
    public int RotationInSpaceY = 180;
    //Count, for how large the maze can be
    public int MaxCount;
    public int Count;

    void Start()
    {
        //MazeGeneration();
    }

    void Update()
    {
        if (Count <= MaxCount)
        {
            MazeGeneration();
        }
        
    }
    void MazeGeneration()
    {
        RandomNumber = Random.Range(1, 5);
        if(RandomNumber == 1)
        {
            Vector3 position = new Vector3(LoactionInSpaceX, LoactionInSpaceY, LoactionInSpaceZ);
            Instantiate(Hallway, position, Quaternion.Euler(0, RotationInSpaceY, 0));
            LoactionInSpaceX -= 5;
        }
        if(RandomNumber == 2)
        {
            Vector3 position = new Vector3(LoactionInSpaceX, LoactionInSpaceY, LoactionInSpaceZ);
            Instantiate(TSection, position, Quaternion.Euler(0, RotationInSpaceY, 0));
            LoactionInSpaceZ -= 5;
            RotationInSpaceY += 90;
        }
        if(RandomNumber == 3)
        {
            Vector3 position = new Vector3(LoactionInSpaceX, LoactionInSpaceY, LoactionInSpaceZ);
            Instantiate(RightTurn, position, Quaternion.Euler(0, RotationInSpaceY, 0));
            LoactionInSpaceZ += 5;
            RotationInSpaceY -= 90;
        }
        if(RandomNumber == 4)
        {
            Vector3 position = new Vector3(LoactionInSpaceX, LoactionInSpaceY, LoactionInSpaceZ);
            Instantiate(LeftTurn, position, Quaternion.Euler(0, RotationInSpaceY, 0));
            LoactionInSpaceZ -= 5;
            RotationInSpaceY += 90;
        }
        if(RandomNumber == 5)
        {
            Vector3 position = new Vector3(LoactionInSpaceX, LoactionInSpaceY, LoactionInSpaceZ);
            Instantiate(EndCap, position, Quaternion.Euler(0, RotationInSpaceY, 0));
        }
        Count += 1;
    }
}
