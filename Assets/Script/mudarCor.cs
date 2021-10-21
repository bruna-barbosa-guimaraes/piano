using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudarCor : MonoBehaviour
{
    private AudioSource audio;
    public Color corPadrao;
    public Color corNova;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (audio.isPlaying)
        {
            GetComponent<Renderer>().material.color = corNova;
        }
        else
        {
            GetComponent<Renderer>().material.color = corPadrao;
        }
    }

}
