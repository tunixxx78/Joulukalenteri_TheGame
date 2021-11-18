using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentManager : MonoBehaviour
{
    [SerializeField] GameObject picture, CoverImage;
    DataHolder dataHolder;
    

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

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("Player"))
        {
            picture.SetActive(true);
            
            Time.timeScale = 0;
            
        }
    }


    public void ReStartTime()
    {
        Time.timeScale = 1;
    }

    
}
