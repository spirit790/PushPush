using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Example_DoTween_Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void MoveRight()
    {
        transform.DOMoveX(8f, 2f);
    }

    public void MoveLeft()
    {
        transform.DOMoveX(-8f, 2f);
    }

    public void RotateRightBox()
    {
        transform.DORotate(new Vector3(0, -270, 0), 1f, RotateMode.Fast);
    }
    public void RotateLeftBox()
    {
        transform.DORotate(new Vector3(0, 270, 0), 1f, RotateMode.Fast);
    }
}
