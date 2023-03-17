using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGererator : MonoBehaviour
{
    public GameObject[] mapObjectPrefab;
    public string dataPath;
    public List<Dictionary<string, object>> data;
    public GameMgr gameMgr;


    void Start()
    {
        gameMgr = GameObject.Find("GameMgr").GetComponent<GameMgr>();
        LoadMapData(1);
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                GameObject ground = Instantiate(mapObjectPrefab[0]) as GameObject;
                ground.name = ground.tag + "(" + j + "," + i + ")";
                ground.transform.parent = GameObject.Find("Ground12x12").transform;
                ground.transform.localPosition = new Vector3(j, 0, -i);
            }
        }
        
        MakeMap();
    }
    public void LoadMapData(int stageNum)
    {
        dataPath = "MapData/" + "LV" + stageNum;
        data = CSVReader.Read(dataPath);
        Debug.Log(data[2]["4"]);
    }

    void MakeMap()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                int dataSet = (int)data[i][j.ToString()];

                if(dataSet !=0)
                {
                    GameObject mapObj = Instantiate(mapObjectPrefab[dataSet]);

                    switch (mapObj.tag)
                    {
                        case "Wall":
                            mapObj.name = mapObj.tag + "(" + j + "," + i + ")";
                            mapObj.transform.parent = GameObject.Find("Map12x12").transform;
                            mapObj.transform.localPosition = new Vector3(j, 0, -i);
                            break;
                        case "Bucket":
                            mapObj.name = mapObj.tag + "(" + j + "," + i + ")";
                            mapObj.transform.parent = GameObject.Find("Map12x12").transform;
                            mapObj.transform.localPosition = new Vector3(j, 0, -i);
                            break;
                        case "Ball":
                            mapObj.name = mapObj.tag + "(" + j + "," + i + ")";
                            mapObj.transform.parent = GameObject.Find("Map12x12").transform;
                            mapObj.transform.localPosition = new Vector3(j, 0, -i);
                            break;
                        case "Player":
                            mapObj.name = mapObj.tag + "(" + j + "," + i + ")";
                            mapObj.transform.parent = GameObject.Find("Map12x12").transform;
                            mapObj.transform.localPosition = new Vector3(j, 0, -i);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        gameMgr.SetBucketsAndBalls();
    }

    public void MapDestroy(int lv)
    {
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        GameObject[] Buckets = GameObject.FindGameObjectsWithTag("Bucket");
        GameObject[] Balls = GameObject.FindGameObjectsWithTag("Ball");
        GameObject Player = GameObject.FindGameObjectWithTag("Player");

        for (int i = 0; i < walls.Length; i++)
        {
            Destroy(walls[i]);
        }
        for (int i = 0; i < Buckets.Length; i++)
        {
            Destroy(Buckets[i]);
        }
        for (int i = 0; i < Balls.Length; i++)
        {
            Destroy(Balls[i]);
        }
        Destroy(Player);
        LoadMapData(lv);
        MakeMap();
    }
}
