using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Example_DoTween_CameraShake : MonoBehaviour
{
    [Range(0,2f)]    public float duration;
    [Range(0, 10f)] public float strength;
    [Range(1, 20)] public int vibrato;
    public Button btn;



    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShakeCamera()
    {
        btn.interactable = true;

        transform.DOShakePosition(duration, strength, vibrato).OnComplete<Tween>(SetOriginPosition);
    }
    void SetOriginPosition()
    {
        btn.interactable = true;
        transform.SetPositionAndRotation(new Vector3(0, 1, -10), Quaternion.Euler(0, 0, 0));
    }
}
