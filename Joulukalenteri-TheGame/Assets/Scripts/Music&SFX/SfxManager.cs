using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SfxManager : MonoBehaviour
{
    public AudioSource walk;

    public void Walk()
    {
        walk.Play();
    }

    public void StopWalking()
    {
        walk.Stop();
    }
}
