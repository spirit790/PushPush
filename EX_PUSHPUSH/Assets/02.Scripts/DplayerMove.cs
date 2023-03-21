using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DplayerMove : MonoBehaviour
{
    public int maxHp=1;
    public int hp;
    public float moveX;
    public Slider hpSlider;

    public GameObject hpBar;

    void Start()
    {
        hp = maxHp;
        hpSlider.value = 1f;
    }


    void Update()
    {
        hpBar.transform.position = Camera.main.WorldToScreenPoint(transform.position+ new Vector3 (0,0.8f,0));

    }

    public void MoveLeft()
    {
        transform.DOLocalMoveX(-moveX, 0.5f);
    }
    public void MoveRight()
    {
        transform.DOLocalMoveX(moveX , 0.5f);        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            hp--;
            hpSlider.value = (float)hp / (float)maxHp;
            Destroy(collision.gameObject);
            if(hp<1)
            {
                Debug.Log("게임종료");
            }
        }
    }

}
