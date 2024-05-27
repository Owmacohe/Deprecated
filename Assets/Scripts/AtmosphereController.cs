using System;
using UnityEngine;
using UnityEngine.UI;

public class AtmosphereController : MonoBehaviour
{
    [SerializeField] Sprite[] backgrounds;
    [SerializeField] AudioClip[] audios;

    [SerializeField] Image background;
    [SerializeField] AudioSource audio;

    int current;

    public void Next()
    {
        background.sprite = backgrounds[current];
        
        audio.Stop();
        audio.clip = audios[current];
        audio.Play();

        current++;
    }

    public void Quit()
    {
        Application.Quit(0);
    }
}