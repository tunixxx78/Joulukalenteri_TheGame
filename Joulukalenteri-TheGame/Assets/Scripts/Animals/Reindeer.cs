using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reindeer : MonoBehaviour
{
    [SerializeField] Animator reindeerAnimator;
    SfxManager sfxManager;
    [SerializeField] GameObject poroText;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            reindeerAnimator.SetTrigger("Reindeer");
            poroText.SetActive(true);
        }
        else
        {
            reindeerAnimator.ResetTrigger("Reindeer");
            poroText.SetActive(false);
        }
    }
}
