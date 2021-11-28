using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    [SerializeField] Animator bunnyAnimator;
    SfxManager sfxManager;
    [SerializeField] GameObject jänisText;

    private void Awake()
    {
        sfxManager = FindObjectOfType<SfxManager>();
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            bunnyAnimator.SetTrigger("Bunny");
            jänisText.SetActive(true);
        }
        else
        {
            bunnyAnimator.ResetTrigger("Bunny");
            jänisText.SetActive(false);
        }
    }
}
