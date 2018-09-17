using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public int playerX;
    public int playerY;
    public int currentFloor;
    public List<TextAsset> floorFiles = new List<TextAsset>();
    private List<string> playerOptions = new List<string>();
    private string[][,] floorMaps = new string[10][,];

    const string NoAction = "H0000";

    //Rooms should be names as following: HWNES
    //If there is no H then it is an actual room. 
    //If it is a Hallway it should start with H and continue with a 1 or 0 for each directional movement possibility


    // Use this for initialization
    void Start()
    {
        for(int i = 0; i<floorFiles.Count - 1; i++) {
            floorMaps[i] = LoadFloorFromFile(floorFiles[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckMoveOptions() {
        string playerLocationID = floorMaps[currentFloor][playerX, playerY];
        if (playerLocationID.Contains("H")) {
            if(playerLocationID[1] == '1') {

            }
            if (playerLocationID[2] == '1') {

            }
            if (playerLocationID[3] == '1') {

            }
            if (playerLocationID[4] == '1') {

            }
        }
    }

    public string[,] LoadFloorFromFile(TextAsset textFile)
    {
        string[] rows = textFile.text.Split('\n');
        string[,] floorMap = new string[rows.Length, rows[0].Length];
        for (int x = 0; x < rows.Length; x++)
        {
            string[] row = rows[x].Split(' ');
            for (int y = 0; y < row.Length; y++)
            {
                floorMap[x, y] = row[y];
            }
        }
        return floorMap;
    }
}

