using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : MonoBehaviour
{
    [SerializeField] Animator mooseAnimator;
    SfxManager sfxManager;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            mooseAnimator.SetTrigger("Hit");
            sfxManager.moose.Play();
        }
        else
        {
            mooseAnimator.ResetTrigger("Hit");
        }
    }

}
