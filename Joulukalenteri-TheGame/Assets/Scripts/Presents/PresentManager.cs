using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentManager : MonoBehaviour
{
    [SerializeField] GameObject picture, CoverImage;
    DataHolder dataHolder;
    [SerializeField] BoxCollider presentCollider;
    

    private void Awake()
    {
        dataHolder = FindObjectOfType<DataHolder>();
        
        
    }

    private void Update()
    {
        if (DataHolder.dataInstance.presentOneOpened == true)
        {
            //CoverImage.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            picture.SetActive(true);

            Time.timeScale = 0;
            Destroy(presentCollider);
        }
    }


    public void ReStartTime()
    {
        Time.timeScale = 1;
    }

    
}
