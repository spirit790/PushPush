using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{
    public Text score;
    public int Cnt;
    public Jun_TweenRuntime tween;

    public void Start()
    {
    }
    public void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Cnt++;
            Destroy(collision.gameObject);
            ScoreCnt();
            tween.Play();
        }
    }

    public void ScoreCnt()
    {
        score.text = $" " + Cnt;
    }
}
