using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hog : MonoBehaviour
{
    [SerializeField] Animator hogAnimator;
    SfxManager sfxManager;
    [SerializeField] GameObject sikaText;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            hogAnimator.SetTrigger("Hog");
            sikaText.SetActive(true);
        }
        else
        {
            hogAnimator.ResetTrigger("Hog");
            sikaText.SetActive(false);
        }
    }
}
