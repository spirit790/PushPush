using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Example_DoTween_Jump : MonoBehaviour
{

    void Start()
    {
        DOTween.Init();
    }


    void Update()
    {
        
    }
    public void Jump()
    {
        transform.DOLocalJump(transform.position, 3.5f, 2, 1f).OnComplete<Tween>(Grounded);
    }
    void Grounded()
    {
        transform.position = Vector3.zero;
    }
}
