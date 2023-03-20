using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{
    public Text score;
    public int Cnt;


    public void Start()
    {
        score = GameObject.Find("ScoreTxt").GetComponent<Text>();
    }
    public void Update()
    {
        ScoreCnt();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Cnt++;
            Destroy(other.gameObject);
        }
    }

    public void ScoreCnt()
    {
        score.text = $"Score : " + Cnt;
    }
}
