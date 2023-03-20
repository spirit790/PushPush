using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMaker : MonoBehaviour
{
    public float curTime;
    public float coolTime;
    public GameObject enemy;
    public bool isRunning = false;

    private void Start()
    {
        coolTime = Random.Range(1.5f, 3.0f);
    }
    void Update()
    {
        MakeEnemy();
    }

    public void MakeEnemy()
    {
        if (isRunning == true)
        {
            curTime += Time.deltaTime;
            if (curTime > coolTime)
            {
                curTime = 0;
                coolTime = Random.Range(1.5f, 3.0f);
                Instantiate(enemy,transform.position,transform.rotation);
            }
        }
        
    }
    public void InitEnemyMaker()
    {
        if (isRunning == true)
            return;

        isRunning = true;
    }

}
