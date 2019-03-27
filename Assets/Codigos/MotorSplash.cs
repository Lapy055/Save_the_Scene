using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MotorSplash : MonoBehaviour {

    public void Pausa()
    {
        Time.timeScale = 0;
    }

    public void IniciarIntro()
    {
        SceneManager.LoadScene("intro");
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.DownArrow)))
        {
            Time.timeScale = 1;
        }
    }
}
