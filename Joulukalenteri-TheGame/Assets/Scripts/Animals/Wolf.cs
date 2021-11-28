using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    [SerializeField] Animator wolfAnimator;
    SfxManager sfxManager;
    [SerializeField] GameObject susiText;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            wolfAnimator.SetTrigger("Wolf");
            susiText.SetActive(true);
        }
        else
        {
            wolfAnimator.ResetTrigger("Wolf");
            susiText.SetActive(false);
        }
    }
}
