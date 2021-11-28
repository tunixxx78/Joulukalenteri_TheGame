using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : MonoBehaviour
{
    [SerializeField] Animator mooseAnimator;
    SfxManager sfxManager;
    [SerializeField] GameObject hirviText;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            mooseAnimator.SetTrigger("Hit");
            hirviText.SetActive(true);
        }
        else
        {
            mooseAnimator.ResetTrigger("Hit");
            hirviText.SetActive(false);
        }
    }

}
