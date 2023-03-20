using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMove : MonoBehaviour
{
    public float downspeed;
    public float dHigh;
    void Start()
    {
        
    }

    void Update()
    {
        transform.DOMoveY(dHigh, downspeed);
    }


}
