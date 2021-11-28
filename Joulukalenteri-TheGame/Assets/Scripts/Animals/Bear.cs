using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    [SerializeField] Animator bearAnimator;
    SfxManager sfxManager;
    [SerializeField] GameObject karhuText;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            bearAnimator.SetTrigger("Bear");
            karhuText.SetActive(true);
        }
        else
        {
            bearAnimator.ResetTrigger("Bear");
            karhuText.SetActive(false);
        }
    }
}
