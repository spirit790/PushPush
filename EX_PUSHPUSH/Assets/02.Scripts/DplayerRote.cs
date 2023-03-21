using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DplayerRote : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float sTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RoteRight()
    {
        transform.DORotate(new Vector3(x, y, z), sTime);
    }
    public void RoteLeft()
    {
        transform.DORotate(new Vector3(x, y, -z), sTime);
    }
}
