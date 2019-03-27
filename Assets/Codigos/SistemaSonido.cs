using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaSonido : MonoBehaviour {

    public static SistemaSonido instancia;
    
    public AudioSource miAudioSourceMusica;
    public AudioClip Musica;
    public AudioClip MusicaPerdedor;
    public AudioClip MusicaGanador;

    public AudioSource miAudioSourceA;
    public AudioSource miAudioSourceB;
    public AudioSource miAudioSourceC;

    public AudioClip AudioBeep;
    public AudioClip AudioGo;
    public AudioClip AudioBombaCayendo;
    public AudioClip AudioExplosion;
    public AudioClip AudioDisparoAcertado;
    public AudioClip AudioDisparoFallido;
    public AudioClip AudioAplausos;
    public AudioClip[] AudioDolor = new AudioClip[7];

    public void Awake()
    {
        instancia = this;
    }

    public void PlayAudioBeep()
    {
        miAudioSourceB.clip = AudioBeep;
        miAudioSourceB.Play();
    }

    public void PlayAudioGo()
    {
        miAudioSourceB.clip = AudioGo;
        miAudioSourceB.Play();
    }

    public void PlayBombaCayendo()
    {
        miAudioSourceA.clip = AudioBombaCayendo;
        miAudioSourceA.Play();
    }

    public void PlayExplosion()
    {
        miAudioSourceB.clip = AudioExplosion;
        miAudioSourceB.Play();
    }

    public void PlayDisparoAcertado()
    {
        miAudioSourceB.clip = AudioDisparoAcertado;
        miAudioSourceA.Stop();
        miAudioSourceB.Play();
    }

    public void PlayDisparoFallido()
    {
        miAudioSourceB.clip = AudioDisparoFallido;
        miAudioSourceB.Play();
    }

    public void PlayAudioDolor()
    {
        int D = Random.Range(0, 7);
        miAudioSourceC.clip = AudioDolor[D];
        miAudioSourceC.Play();
    }
    
    public void PlayPerdiste()
    {
        miAudioSourceMusica.clip = MusicaPerdedor;
        miAudioSourceMusica.loop = false;
        miAudioSourceMusica.Play();
    }

    public void PlayGanaste()
    {
        miAudioSourceC.clip = AudioAplausos;
        miAudioSourceC.volume = 0.5f;
        miAudioSourceC.Play();
        miAudioSourceMusica.clip = MusicaGanador;
        miAudioSourceMusica.volume = 0.5f;
        miAudioSourceMusica.loop = false;
        miAudioSourceMusica.Play();
    }

    public void ReinicarMusica()
    {
        miAudioSourceMusica.Stop();
        miAudioSourceC.volume = 1f;
        miAudioSourceMusica.clip = Musica;
        miAudioSourceMusica.volume = 0.2f;
        miAudioSourceMusica.loop = true;
        miAudioSourceMusica.Play();
    }
}
