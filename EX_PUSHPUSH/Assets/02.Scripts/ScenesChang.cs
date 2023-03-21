using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesChang : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void SceneCh()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitScen()
    {
        Application.Quit();
    }
}
