using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SfxManager : MonoBehaviour
{
    public AudioSource walk, moose;

    public void Walk()
    {
        walk.Play();
    }
    public void Moose()
    {
        moose.Play();
    }

    
}
