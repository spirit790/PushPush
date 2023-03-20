using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DplayerMove : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void MoveLeft()
    {
        transform.DOLocalMoveX(1f, 0.5f);
        
    }
    public void MoveRight()
    {
        transform.DOLocalMoveX(-1f, 0.5f);
        
    }

}
