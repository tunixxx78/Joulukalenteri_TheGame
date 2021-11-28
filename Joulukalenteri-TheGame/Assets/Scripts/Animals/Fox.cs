using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [SerializeField] Animator foxAnimator;
    SfxManager sfxManager;
    [SerializeField] GameObject kettuText;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            foxAnimator.SetTrigger("Fox");
            kettuText.SetActive(true);
        }
        else
        {
            foxAnimator.ResetTrigger("Fox");
            kettuText.SetActive(false);
        }
    }
}
