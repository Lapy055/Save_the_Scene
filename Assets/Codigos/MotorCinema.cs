using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MotorCinema : MonoBehaviour {

    public AudioSource miMusica;
    public AudioClip buenos;
    public AudioClip malos;
    private bool HacerFadeOut = false;

    public void IniciarJuego()
    {
        SceneManager.LoadScene("main");
    }

    public void PlaySonidoBuenos()
    {
        this.GetComponent<AudioSource>().clip = buenos;
        this.GetComponent<AudioSource>().Play();
    }

    public void StopSonidoBuenos()
    {
        this.GetComponent<AudioSource>().Stop();
    }

    public void PlaySonidoMalos()
    {
        this.GetComponent<AudioSource>().clip = malos;
        this.GetComponent<AudioSource>().Play();
    }

    public void StopSonidoMalos()
    {
        this.GetComponent<AudioSource>().Stop();
    }

    public void FadeOutMusica()
    {
        HacerFadeOut = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("main");
        }

        if (HacerFadeOut)
        {
            miMusica.volume -= 0.005f;
        }
    }
}
