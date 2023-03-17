using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    RaycastHit hit2;

    public GameMgr gameMgr;

    void Start()
    {
        gameMgr = GameObject.Find("GameMgr").GetComponent<GameMgr>();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckOther(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckOther(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckOther(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckOther(Vector3.back);
        }
    }
    public void CheckOther(Vector3 dir)
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(dir),out hit,1.0f))
        {
            Transform tr = hit.collider.transform;
            switch (hit.collider.tag)
            {
                case"Ball":
                    if(Physics.Raycast(tr.position,tr.TransformDirection(dir),out hit2,1.0f))
                    {
                        switch (hit2.collider.tag)
                        {
                            case"Bucket":
                                Debug.Log("2Ä­µÚ ::" + hit2.collider.tag);
                                break;
                            case "Ball":
                                Debug.Log("2Ä­µÚ ::" + hit2.collider.tag);
                                break;
                            case "Wall":
                                Debug.Log("2Ä­µÚ ::" + hit2.collider.tag);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        tr.Translate(dir);
                        transform.Translate(dir);//player
                        gameMgr.CheckBallPosition();
                    }
                    Debug.Log("BAll");
                    break;
                case "Wall":
                    Debug.Log("º®ÀÌ´Ù");
                    break;
                default:
                    break;
            }
        }
        else
        {
            transform.Translate(dir);
            gameMgr.CheckBallPosition();
        }
    }
}
