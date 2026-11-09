using UnityEngine;

public class MG_Maze_Count_Script : MonoBehaviour
{

    public int MaxCount;
    public int Count = 0;
    public bool GenerateMaze;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Count = 0;
        GenerateMaze = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnApplicationQuit()
    {
        Count = 0;
        Debug.Log("bgiupuoerwhgbuiebg uoerhbej;rsgher79iuberiuo");
    }
}
