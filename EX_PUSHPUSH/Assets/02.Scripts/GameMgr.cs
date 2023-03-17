using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public GameObject[] buckets;
    public GameObject[] balls;
    public int curCnt = 0;
    public int maxCnt = 0;
    public int correctCnt;
    public int inCorrectCnt;
    public int curLv = 1;
    public int maxLv = 2;
    public MapGererator mapGererator;
    public Text scoreText;
    public Text stageNumText;


    public void SetBucketsAndBalls()
    {
        StartCoroutine(FindBucketsAndBall());
    }
    IEnumerator FindBucketsAndBall()
    {
        yield return buckets = new GameObject[GameObject.FindGameObjectsWithTag("Bucket").Length];
        yield return balls = new GameObject[GameObject.FindGameObjectsWithTag("Ball").Length];

        buckets = GameObject.FindGameObjectsWithTag("Bucket");
        balls = GameObject.FindGameObjectsWithTag("Ball");

        curCnt = 0;
        maxCnt = balls.Length;

        //scoreText.text = curCnt + "/" + maxCnt;
        //stageNumText.text = "STAGE:" + curLv.ToString();
        Debug.Log("MAX COUNT:::::" + maxCnt);
    }   
    public void CheckBallPosition()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            for (int j = 0; j < balls.Length; j++)
            {
                if(buckets[i].transform.position == balls[j].transform.position)
                {
                    correctCnt++;
                    curCnt = correctCnt;
                }
            }
        }
        correctCnt = 0;
        //scoreText.text = curCnt + "/" + maxCnt;
        if(curCnt ==maxCnt)
        {
            Debug.Log("STAGE CLEAR!!!");
            curLv++;
            curCnt = 0;
            maxCnt = 0;
            if (curLv != maxLv)
                mapGererator.MapDestroy(curLv);
            else
                Debug.Log("올스클");
        }
    }
    public void ReTry()
    {
        Debug.Log("재시작");
        mapGererator.MapDestroy(curLv);
    }

}